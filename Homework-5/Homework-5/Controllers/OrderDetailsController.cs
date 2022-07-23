using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Le_Crystal_HW5.DAL;
using Le_Crystal_HW5.Models;

namespace Le_Crystal_HW5.Controllers
{
    public class OrderDetailsController : Controller
    {
        private readonly AppDbContext _context;

        public OrderDetailsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: OrderDetails
        public async Task<IActionResult> Index(int? orderID)
        {
            if (orderID == null)
            {
                return View("Error", new String[] { "Please specify a registration to view!" });
            }

            //limit the list to only the registration details that belong to this registration
            List<OrderDetail> rds = _context.OrderDetails
                                          .Include(rd => rd.Product)
                                          .Where(rd => rd.Order.OrderID == orderID)
                                          .ToList();

            return View(rds);
        }

        // GET: OrderDetails/Details/5
        

        // GET: OrderDetails/Create
        public IActionResult Create(int orderID)
        {
            //create a new instance of the RegistrationDetail class
            OrderDetail od = new OrderDetail();

            //find the registration that should be associated with this registration
            Order dbOrder = _context.Orders.Find(orderID);

            //set the new registration detail's registration equal to the registration you just found
            od.Order = dbOrder;

            //populate the ViewBag with a list of existing courses
            ViewBag.AllProducts = GetAllProducts();

            //pass the newly created registration detail to the view
            return View(od);
        }


        // POST: OrderDetails/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(OrderDetail orderDetail, int SelectedProduct)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.AllProducts = GetAllProducts();
                return View(orderDetail);
            }
            //find the course to be associated with this order
            Product dbProduct = _context.Products.Find(SelectedProduct);

            //set the registration detail's course to be equal to the one we just found
            orderDetail.Product = dbProduct;
            //find
            Order dbOrder = _context.Orders.Find(orderDetail.Order.OrderID);

            //set the registration on the registration detail equal to the registration that we just found
            orderDetail.Order = dbOrder;
            orderDetail.Price = dbProduct.Price;
            orderDetail.ExtendedPrice = orderDetail.Quantity * orderDetail.Price;

            //add to database
            _context.Add(orderDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Orders", new { id = orderDetail.Order.OrderID });
        }

        // GET: OrderDetails/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return View("Error", new String[] { "Please specify a order detail to edit!" });
            }

            OrderDetail orderDetail = await _context.OrderDetails
                                                   .Include(od => od.Product)
                                                   .Include(od => od.Order)
                                                   .FirstOrDefaultAsync(od => od.OrderDetailID == id);
            if (orderDetail == null)
                if (orderDetail == null)
                {
                    return View("Error", new String[] { "This order detail was not found" });
                }
            return View(orderDetail);
        }

        // POST: OrderDetails/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderDetailID,Quantity,Price,ExtendedPrice")] OrderDetail orderDetail)
        {
            if (id != orderDetail.OrderDetailID)
            {
                return View("Error", new String[] { "There was a problem editing this record. Try again!" });
            }

            if (ModelState.IsValid == false)
            {
                return View(orderDetail);
            }
            OrderDetail dbRD;
            //if code gets this far, update the record
            try
            {
                //find the existing registration detail in the database
                //include both registration and course
                dbRD = _context.OrderDetails
                      .Include(rd => rd.Product)
                      .Include(rd => rd.Order)
                      .FirstOrDefault(rd => rd.OrderDetailID == orderDetail.OrderDetailID);

                //update the scalar properties
                dbRD.Quantity = orderDetail.Quantity;
                dbRD.Price = dbRD.Product.Price;
                dbRD.ExtendedPrice = dbRD.Quantity * dbRD.Price;

                //save changes
                _context.Update(dbRD);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was a problem editing this record", ex.Message });
            }

            //if code gets this far, go back to the registration details index page
            return RedirectToAction("Details", "Orders", new { id = dbRD.Order.OrderID });
        }

        // GET: OrderDetails/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            OrderDetail orderDetail = await _context.OrderDetails.Include(o => o.Order)
                .FirstOrDefaultAsync(m => m.OrderDetailID == id);
            if (orderDetail == null)
            {
                return NotFound();
            }

            return View(orderDetail);
        }

        // POST: OrderDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            OrderDetail orderDetail = await _context.OrderDetails.Include(od => od.Order).FirstOrDefaultAsync(od => od.OrderDetailID == id);
            _context.OrderDetails.Remove(orderDetail);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Orders", new { id = orderDetail.Order.OrderID });

        }

        private bool OrderDetailExists(int id)
        {
            return _context.OrderDetails.Any(e => e.OrderDetailID == id);
        }

        private SelectList GetAllProducts()
        {
            //create a list for all the courses
            List<Product> allProducts = _context.Products.ToList();

            //the user MUST select a course, so you don't need a dummy option for no course

            //use the constructor on select list to create a new select list with the options
            SelectList slAllProducts = new SelectList(allProducts, nameof(Product.ProductID), nameof(Product.ProductName));

            return slAllProducts;
        }
    }
}
