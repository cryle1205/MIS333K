using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//TODO: Change these using statements to match your project (LastName_FirstName_HW3)
using Le_Crystal_HW3.DAL;
using Le_Crystal_HW3.Models;


//TODO: Change this namespace to match your project (LastName_FirstName_HW3)
namespace Le_Crystal_HW3.Seeding
{
	public static class SeedMovies
	{
		public static void SeedAllMovies(AppDbContext db)
		{
		//Create a new list for all of the movies
		List<Movie> AllMovies = new List<Movie>();
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3498820",
			Title = "Captain America: Civil War",
			Description = "Following the events of Age of Ultron, the collective governments of the world pass an act designed to regulate all superhuman activity. This polarizes opinion amongst the Avengers, causing two factions to side with Iron Man or Captain America, which causes an epic battle between former allies.",
			ReleaseDate = new DateTime(2016,4,27),
			VoteAverage = 7.1m,
			VoteCount = 7462,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://marvel.com/captainamericapremiere"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2310332",
			Title = "The Hobbit: The Battle of the Five Armies",
			Description = "Immediately after the events of The Desolation of Smaug, Bilbo and the dwarves try to defend Erebor's mountain of treasure from others who claim it: the men of the ruined Laketown and the elves of Mirkwood. Meanwhile an army of Orcs led by Azog the Defiler is marching on Erebor, fueled by the rise of the dark lord Sauron. Dwarves, elves and men must unite, and the hope for Middle-Earth falls into Bilbo's hands.",
			ReleaseDate = new DateTime(2014,12,10),
			VoteAverage = 7.1m,
			VoteCount = 4884,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.thehobbit.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0121766",
			Title = "Star Wars: Episode III - Revenge of the Sith",
			Description = "Years after the onset of the Clone Wars, the noble Jedi Knights lead a massive clone army into a galaxy-wide battle against the Separatists. When the sinister Sith unveil a thousand-year-old plot to rule the galaxy, the Republic crumbles and from its ashes rises the evil Galactic Empire. Jedi hero Anakin Skywalker is seduced by the dark side of the Force to become the Emperor's new apprentice, Darth Vader. The Jedi are decimated, as Obi-Wan Kenobi and Jedi Master Yoda are forced into hiding. The only hope for the galaxy are Anakin's own offspring  - the twin children born in secrecy who will grow up to become heroes.",
			ReleaseDate = new DateTime(2005,5,17),
			VoteAverage = 7.1m,
			VoteCount = 4200,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.starwars.com/films/star-wars-episode-iii-revenge-of-the-sith"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2381249",
			Title = "Mission: Impossible - Rogue Nation",
			Description = "Ethan and team take on their most impossible mission yet, eradicating the Syndicate - an International rogue organization as highly skilled as they are, committed to destroying the IMF.",
			ReleaseDate = new DateTime(2015,7,23),
			VoteAverage = 7.1m,
			VoteCount = 3274,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.missionimpossible.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1211837",
			Title = "Doctor Strange",
			Description = "After his career is destroyed, a brilliant but arrogant surgeon gets a new lease on life when a sorcerer takes him under his wing and trains him to defend the world against evil.",
			ReleaseDate = new DateTime(2016,10,25),
			VoteAverage = 7.1m,
			VoteCount = 5880,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://marvel.com/doctorstrange"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1596343",
			Title = "Fast Five",
			Description = "Former cop Brian O'Conner partners with ex-con Dom Toretto on the opposite side of the law. Since Brian and Mia Toretto broke Dom out of custody, they've blown across many borders to elude authorities. Now backed into a corner in Rio de Janeiro, they must pull one last job in order to gain their freedom.",
			ReleaseDate = new DateTime(2011,4,20),
			VoteAverage = 7.1m,
			VoteCount = 2491,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.watchvideoseries.com/movies/fast-five-2011-2/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1323594",
			Title = "Despicable Me",
			Description = "Villainous Gru lives up to his reputation as a despicable, deplorable and downright unlikable guy when he hatches a plan to steal the moon from the sky. But he has a tough time staying on task after three orphans land in his care.",
			ReleaseDate = new DateTime(2010,7,8),
			VoteAverage = 7.1m,
			VoteCount = 6595,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://www.despicable.me/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0099785",
			Title = "Home Alone",
			Description = "Eight-year-old Kevin McCallister makes the most of the situation after his family unwittingly leaves him behind when they go on Christmas vacation. But when a pair of bungling burglars set their sights on Kevin's house, the plucky kid stands ready to defend his territory. By planting booby traps galore, adorably mischievous Kevin stands his ground as his frantic mother attempts to race home before.",
			ReleaseDate = new DateTime(1990,11,9),
			VoteAverage = 7.1m,
			VoteCount = 2487,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG,
			URL = "https://www.foxconnect.com/home-alone-4.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1772341",
			Title = "Wreck-It Ralph",
			Description = "Wreck-It Ralph is the 9-foot-tall, 643-pound villain of an arcade video game named Fix-It Felix Jr., in which the game's titular hero fixes buildings that Ralph destroys. Wanting to prove he can be a good guy and not just a villain, Ralph escapes his game and lands in Hero's Duty, a first-person shooter where he helps the game's hero battle against alien invaders. He later enters Sugar Rush, a kart racing game set on tracks made of candies, cookies and other sweets. There, Ralph meets Vanellope von Schweetz who has learned that her game is faced with a dire threat that could affect the entire arcade, and one that Ralph may have inadvertently started.",
			ReleaseDate = new DateTime(2012,11,1),
			VoteAverage = 7.1m,
			VoteCount = 4656,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Family"),
			Rating = Rating.PG,
			URL = "http://disney.go.com/wreck-it-ralph"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120855",
			Title = "Tarzan",
			Description = "Tarzan was a small orphan who was raised by an ape named Kala since he was a child. He believed that this was his family, but on an expedition Jane Porter is rescued by Tarzan. He then finds out that he's human. Now Tarzan must make the decision as to which family he should belong to...",
			ReleaseDate = new DateTime(1999,6,18),
			VoteAverage = 7.1m,
			VoteCount = 1715,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.G,
			URL = "http://disneydvd.disney.go.com/tarzanr-special-edition.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0181689",
			Title = "Minority Report",
			Description = "John Anderton is a top 'Precrime' cop in the late-21st century, when technology can predict crimes before they're committed. But Anderton becomes the quarry when another investigator targets him for a murder charge.",
			ReleaseDate = new DateTime(2002,6,20),
			VoteAverage = 7.1m,
			VoteCount = 2663,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1270798",
			Title = "X-Men: First Class",
			Description = "Before Charles Xavier and Erik Lensherr took the names Professor X and Magneto, they were two young men discovering their powers for the first time. Before they were arch-enemies, they were closest of friends, working together with other mutants (some familiar, some new), to stop the greatest threat the world has ever known.",
			ReleaseDate = new DateTime(2011,5,24),
			VoteAverage = 7.1m,
			VoteCount = 5252,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.x-menfirstclassmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0087469",
			Title = "Indiana Jones and the Temple of Doom",
			Description = "After arriving in India, Indiana Jones is asked by a desperate village to find a mystical stone. He agrees and stumbles upon a secret cult plotting a terrible plan in the catacombs of an ancient palace.",
			ReleaseDate = new DateTime(1984,5,23),
			VoteAverage = 7.1m,
			VoteCount = 2841,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = "http://www.indianajones.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1446192",
			Title = "Rise of the Guardians",
			Description = "When an evil spirit known as Pitch lays down the gauntlet to take over the world, the immortal Guardians must join forces for the first time to protect the hopes, beliefs and imagination of children all over the world.",
			ReleaseDate = new DateTime(2012,11,21),
			VoteAverage = 7.1m,
			VoteCount = 1981,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG,
			URL = "http://www.riseoftheguardians.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0100802",
			Title = "Total Recall",
			Description = "Construction worker Douglas Quaid discovers a memory chip in his brain during a virtual-reality trip. He also finds that his past has been invented to conceal a plot of planetary domination. Soon, he's off to Mars to find out who he is and who planted the chip.",
			ReleaseDate = new DateTime(1990,6,1),
			VoteAverage = 7.1m,
			VoteCount = 1745,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0195685",
			Title = "Erin Brockovich",
			Description = "A twice-divorced mother of three who sees an injustice, takes on the bad guy and wins -- with a little help from her push-up bra. Erin goes to work for an attorney and comes across medical records describing illnesses clustered in one nearby town. She starts investigating and soon exposes a monumental cover-up.",
			ReleaseDate = new DateTime(2000,3,17),
			VoteAverage = 7.1m,
			VoteCount = 730,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.brockovich.com/movie.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0099088",
			Title = "Back to the Future Part III",
			Description = "The final installment of the Back to the Future trilogy finds Marty digging the trusty DeLorean out of a mineshaft and looking up Doc in the Wild West of 1885. But when their time machine breaks down, the travelers are stranded in a land of spurs. More problems arise when Doc falls for pretty schoolteacher Clara Clayton, and Marty tangles with Buford Tannen.",
			ReleaseDate = new DateTime(1990,5,25),
			VoteAverage = 7.1m,
			VoteCount = 2978,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG,
			URL = "http://www.backtothefuture.com/movies/backtothefuture3"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0104257",
			Title = "A Few Good Men",
			Description = "When cocky military lawyer Lt. Daniel Kaffee and his co-counsel, Lt. Cmdr. JoAnne Galloway, are assigned to a murder case, they uncover a hazing ritual that could implicate high-ranking officials such as shady Col. Nathan Jessep.",
			ReleaseDate = new DateTime(1992,12,11),
			VoteAverage = 7.1m,
			VoteCount = 899,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.sonypictures.com/movies/afewgoodmen/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1024648",
			Title = "Argo",
			Description = "As the Iranian revolution reaches a boiling point, a CIA 'exfiltration' specialist concocts a risky plan to free six Americans who have found shelter at the home of the Canadian ambassador.",
			ReleaseDate = new DateTime(2012,10,11),
			VoteAverage = 7.1m,
			VoteCount = 3473,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = "http://argothemovie.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1285016",
			Title = "The Social Network",
			Description = "On a fall night in 2003, Harvard undergrad and computer programming genius Mark Zuckerberg sits down at his computer and heatedly begins working on a new idea. In a fury of blogging and programming, what begins in his dorm room as a small site among friends soon becomes a global social network and a revolution in communication. A mere six years and 500 million friends later, Mark Zuckerberg is the youngest billionaire in history... but for this entrepreneur, success leads to both personal and legal complications.",
			ReleaseDate = new DateTime(2010,9,30),
			VoteAverage = 7.1m,
			VoteCount = 3492,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.thesocialnetwork-movie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0362227",
			Title = "The Terminal",
			Description = "Viktor Navorski is a man without a country; his plane took off just as a coup d'etat exploded in his homeland, leaving it in shambles, and now he's stranded at Kennedy Airport, where he's holding a passport that nobody recognizes. While quarantined in the transit lounge until authorities can figure out what to do with him, Viktor simply goes on living and courts romance with a beautiful flight attendant.",
			ReleaseDate = new DateTime(2004,6,17),
			VoteAverage = 7.1m,
			VoteCount = 1974,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG13,
			URL = "http://www.theterminal-themovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0103874",
			Title = "Dracula",
			Description = "When Dracula leaves the captive Jonathan Harker and Transylvania for London in search of Mina Harker -- the spitting image of Dracula's long-dead wife, Elisabeta -- obsessed vampire hunter Dr. Van Helsing sets out to end the madness.",
			ReleaseDate = new DateTime(1992,11,13),
			VoteAverage = 7.1m,
			VoteCount = 1087,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0092890",
			Title = "Dirty Dancing",
			Description = "Expecting the usual tedium that accompanies a summer in the Catskills with her family, 17-year-old Frances 'Baby' Houseman is surprised to find herself stepping into the shoes of a professional hoofer and unexpectedly falling in love.",
			ReleaseDate = new DateTime(1987,8,21),
			VoteAverage = 7.1m,
			VoteCount = 1371,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.PG13,
			URL = "http://lionsgateathome.com/dirty-dancing"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0061852",
			Title = "The Jungle Book",
			Description = "The boy Mowgli makes his way to the man-village with Bagheera, the wise panther. Along the way he meets jazzy King Louie, the hypnotic snake Kaa and the lovable, happy-go-lucky bear Baloo, who teaches Mowgli 'The Bare Necessities' of life and the true meaning of friendship.",
			ReleaseDate = new DateTime(1967,10,17),
			VoteAverage = 7.1m,
			VoteCount = 1791,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Family"),
			Rating = Rating.G,
			URL = "http://movies.disney.com/the-jungle-book-1967"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2361509",
			Title = "The Intern",
			Description = "70-year-old widower Ben Whittaker has discovered that retirement isn't all it's cracked up to be. Seizing an opportunity to get back in the game, he becomes a senior intern at an online fashion site, founded and run by Jules Ostin.",
			ReleaseDate = new DateTime(2015,9,24),
			VoteAverage = 7.1m,
			VoteCount = 1926,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG13,
			URL = "http://www.theinternmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0217505",
			Title = "Gangs of New York",
			Description = "It's 1863. America was born in the streets. Amsterdam Vallon returns to the Five Points of America to seek vengeance against the psychotic gangland kingpin, Bill the Butcher, who murdered his father years earlier. With an eager pickpocket by his side and a whole new army, Vallon fights his way to seek vengeance on the Butcher and restore peace in the area.",
			ReleaseDate = new DateTime(2002,12,14),
			VoteAverage = 7.1m,
			VoteCount = 1964,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://video.movies.go.com/gangsofnewyork/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0455944",
			Title = "The Equalizer",
			Description = "In The Equalizer, Denzel Washington plays McCall, a man who believes he has put his mysterious past behind him and dedicated himself to beginning a new, quiet life. But when McCall meets Teri (Chloe Grace Moretz), a young girl under the control of ultra-violent Russian gangsters, he can;t stand idly by - he has to help her. Armed with hidden skills that allow him to serve vengeance against anyone who would brutalize the helpless, McCall comes out of his self-imposed retirement and finds his desire for justice reawakened. If someone has a problem, if the odds are stacked against them, if they have nowhere else to turn, McCall will help. He is The Equalizer.",
			ReleaseDate = new DateTime(2014,9,24),
			VoteAverage = 7.1m,
			VoteCount = 2997,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120663",
			Title = "Eyes Wide Shut",
			Description = "After Dr. Bill Hartford's wife, Alice, admits to having sexual fantasies about a man she met, Bill becomes obsessed with having a sexual encounter. He discovers an underground sexual group and attends one of their meetings -- and quickly discovers that he is in over his head.",
			ReleaseDate = new DateTime(1999,7,14),
			VoteAverage = 7.1m,
			VoteCount = 1266,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery"),
			Rating = Rating.R,
			URL = "http://eyeswideshut.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1219289",
			Title = "Limitless",
			Description = "A paranoia-fueled action thriller about an unsuccessful writer whose life is transformed by a top-secret 'smart drug' that allows him to use 100% of his brain and become a perfect version of himself. His enhanced abilities soon attract shadowy forces that threaten his new life in this darkly comic and provocative film.",
			ReleaseDate = new DateTime(2011,3,8),
			VoteAverage = 7.1m,
			VoteCount = 3888,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.PG13,
			URL = "http://www.iamrogue.com/limitless/fullsite/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0945513",
			Title = "Source Code",
			Description = "Decorated soldier Captain Colter Stevens wakes up in the body of an unknown man, discovering he's involved in a mission to find the bomber of a Chicago commuter train. He learns he's part of a top-secret experimental program that enables him to experience the final 8 minutes of another person's life. Colter re-lives the train incident over and over again, gathering more clues each time. But can he discover who is responsible for the attack before the next one happens?",
			ReleaseDate = new DateTime(2011,3,30),
			VoteAverage = 7.1m,
			VoteCount = 2752,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.PG13,
			URL = "http://www.enterthesourcecode.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0275847",
			Title = "Lilo & Stitch",
			Description = "A lonely Hawaiian girl named Lilo is being raised by her older sister, Nani, after their parents die -- under the watch of social worker Cobra Bubbles. When Lilo adopts a funny-looking dog and names him 'Stitch,' she doesn't realize her new best friend is a wacky alien created by mad scientist Dr. Jumba.",
			ReleaseDate = new DateTime(2002,6,21),
			VoteAverage = 7.1m,
			VoteCount = 1371,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0099674",
			Title = "The Godfather: Part III",
			Description = "In the midst of trying to legitimize his business dealings in 1979 New York and Italy, aging mafia don, Michael Corleone seeks forgiveness for his sins while taking a young protege under his wing.",
			ReleaseDate = new DateTime(1990,12,24),
			VoteAverage = 7.1m,
			VoteCount = 1589,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://www.imdb.com/title/tt0099674/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0396171",
			Title = "Perfume: The Story of a Murderer",
			Description = "Jean-Baptiste Grenouille, born in the stench of 18th century Paris, develops a superior olfactory sense, which he uses to create the world's finest perfumes. However, his work takes a dark turn as he tries to preserve scents in the search for the ultimate perfume.",
			ReleaseDate = new DateTime(2006,9,13),
			VoteAverage = 7.1m,
			VoteCount = 1198,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://www.parfum.film.de/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0134119",
			Title = "The Talented Mr. Ripley",
			Description = "Tom Ripley is a calculating young man who believes it's better to be a fake somebody than a real nobody. Opportunity knocks in the form of a wealthy U.S. shipbuilder who hires Tom to travel to Italy to bring back his playboy son, Dickie. Ripley worms his way into the idyllic lives of Dickie and his girlfriend, plunging into a daring scheme of duplicity, lies and murder.",
			ReleaseDate = new DateTime(1999,12,25),
			VoteAverage = 7.1m,
			VoteCount = 790,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = "http://www.miramax.com/movie/the-talented-mr-ripley/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0093105",
			Title = "Good Morning, Vietnam",
			Description = "Radio funny man Adrian Cronauer is sent to Vietnam to bring a little comedy back into the lives of the soldiers. After setting up shop, Cronauer delights the G.I.s but shocks his superior officer, Sergeant Major Dickerson, with his irreverent take on the war. While Dickerson attempts to censor Cronauer's broadcasts, Cronauer pursues a relationship with a Vietnamese girl named Trinh, who shows him the horrors of war first-hand.",
			ReleaseDate = new DateTime(1987,12,23),
			VoteAverage = 7.1m,
			VoteCount = 658,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0084516",
			Title = "Poltergeist",
			Description = "Steve Freeling lives with his wife, Diane, and their three children, Dana, Robbie, and Carol Anne, in Southern California where he sells houses for the company that built the neighborhood. It starts with just a few odd occurrences, such as broken dishes and furniture moving around by itself. However, when he realizes that something truly evil haunts his home, Steve calls in a team of parapsychologists led by Dr. Lesh to help before it's too late.",
			ReleaseDate = new DateTime(1982,6,4),
			VoteAverage = 7.1m,
			VoteCount = 811,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0107822",
			Title = "The Piano",
			Description = "After a long voyage from Scotland, pianist Ada McGrath and her young daughter, Flora, are left with all their belongings, including a piano, on a New Zealand beach. Ada, who has been mute since childhood, has been sold into marriage to a local man named Alisdair Stewart. Making little attempt to warm up to Alisdair, Ada soon becomes intrigued by his Maori-friendly acquaintance, George Baines, leading to tense, life-altering conflicts.",
			ReleaseDate = new DateTime(1993,5,19),
			VoteAverage = 7.1m,
			VoteCount = 290,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0072308",
			Title = "The Towering Inferno",
			Description = "At the opening party of a colossal - but poorly constructed - office building, a massive fire breaks out that threatens to destroy the tower and everyone in it.",
			ReleaseDate = new DateTime(1974,12,14),
			VoteAverage = 7.1m,
			VoteCount = 230,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1638355",
			Title = "The Man from U.N.C.L.E.",
			Description = "At the height of the Cold War, a mysterious criminal organization plans to use nuclear weapons and technology to upset the fragile balance of power between the United States and Soviet Union. CIA agent Napoleon Solo and KGB agent Illya Kuryakin are forced to put aside their hostilities and work together to stop the evildoers in their tracks. The duo's only lead is the daughter of a missing German scientist, whom they must find soon to prevent a global catastrophe.",
			ReleaseDate = new DateTime(2015,8,13),
			VoteAverage = 7.1m,
			VoteCount = 2306,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0499549",
			Title = "Avatar",
			Description = "In the 22nd century, a paraplegic Marine is dispatched to the moon Pandora on a unique mission, but becomes torn between following orders and protecting an alien civilization.",
			ReleaseDate = new DateTime(2009,12,10),
			VoteAverage = 7.2m,
			VoteCount = 12114,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG13,
			URL = "http://www.avatarmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0451279",
			Title = "Wonder Woman",
			Description = "An Amazon princess comes to the world of Man to become the greatest of the female superheroes.",
			ReleaseDate = new DateTime(2017,5,30),
			VoteAverage = 7.2m,
			VoteCount = 5025,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.warnerbros.com/wonder-woman"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3183660",
			Title = "Fantastic Beasts and Where to Find Them",
			Description = "In 1926, Newt Scamander arrives at the Magical Congress of the United States of America with a magically expanded briefcase, which houses a number of dangerous creatures and their habitats. When the creatures escape from the briefcase, it sends the American wizarding authorities after Newt, and threatens to strain even further the state of magical and non-magical relations.",
			ReleaseDate = new DateTime(2016,11,16),
			VoteAverage = 7.2m,
			VoteCount = 5612,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = "http://www.fantasticbeasts.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0454876",
			Title = "Life of Pi",
			Description = "The story of an Indian boy named Pi, a zookeeper's son who finds himself in the company of a hyena, zebra, orangutan, and a Bengal tiger after a shipwreck sets them adrift in the Pacific Ocean.",
			ReleaseDate = new DateTime(2012,11,20),
			VoteAverage = 7.2m,
			VoteCount = 5912,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = "http://www.lifeofpimovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1119646",
			Title = "The Hangover",
			Description = "When three friends finally come to after a raucous night of bachelor-party revelry, they find a baby in the closet and a tiger in the bathroom. But they can't seem to locate their best friend, Doug, who's supposed to be tying the knot. Launching a frantic search for Doug, the trio perseveres through a nasty hangover to try to make it to the church on time.",
			ReleaseDate = new DateTime(2009,6,5),
			VoteAverage = 7.2m,
			VoteCount = 6324,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.R,
			URL = "http://hangoverpart2.warnerbros.com/dvd/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0240772",
			Title = "Ocean's Eleven",
			Description = "Less than 24 hours into his parole, charismatic thief Danny Ocean is already rolling out his next plan: In one night, Danny's hand-picked crew of specialists will attempt to steal more than $150 million from three Las Vegas casinos. But to score the cash, Danny risks his chances of reconciling with ex-wife, Tess.",
			ReleaseDate = new DateTime(2001,12,7),
			VoteAverage = 7.2m,
			VoteCount = 3857,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.PG13,
			URL = "http://www.warnerbros.co.uk/movies/oceans-eleven"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1707386",
			Title = "Les Miserables",
			Description = "An adaptation of the successful stage musical based on Victor Hugo's classic novel set in 19th-century France, in which a paroled prisoner named Jean Valjean seeks redemption.",
			ReleaseDate = new DateTime(2012,12,18),
			VoteAverage = 7.2m,
			VoteCount = 1925,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.lesmiserablesfilm.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0106977",
			Title = "The Fugitive",
			Description = "Wrongfully accused of murdering his wife, Richard Kimble escapes from the law in an attempt to find her killer and clear his name. Pursuing him is a team of U.S. marshals led by Deputy Samuel Gerard, a determined detective who will not rest until Richard is captured. As Richard leads the team through a series of intricate chases, he discovers the secrets behind his wife's death and struggles to expose the killer before it is too late.",
			ReleaseDate = new DateTime(1993,8,6),
			VoteAverage = 7.2m,
			VoteCount = 1240,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0096438",
			Title = "Who Framed Roger Rabbit",
			Description = "'Toon star Roger is worried that his wife Jessica is playing pattycake with someone else, so the studio hires detective Eddie Valiant to snoop on her. But the stakes are quickly raised when Marvin Acme is found dead and Roger is the prime suspect.",
			ReleaseDate = new DateTime(1988,6,21),
			VoteAverage = 7.2m,
			VoteCount = 1466,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0119822",
			Title = "As Good as It Gets",
			Description = "New York City. Melvin Udall, a cranky, bigoted, obsessive-compulsive writer, finds his life turned upside down when neighboring gay artist Simon is hospitalized and his dog is entrusted to Melvin. In addition, Carol, the only waitress who will tolerate him, must leave work to care for her sick son, making it impossible for Melvin to eat breakfast.",
			ReleaseDate = new DateTime(1997,12,19),
			VoteAverage = 7.2m,
			VoteCount = 946,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt4116284",
			Title = "The Lego Batman Movie",
			Description = "In the irreverent spirit of fun that made The Lego Movie a worldwide phenomenon, the self-described leading man of that ensemble,  Lego Batman, stars in his own big-screen adventure. But there are big changes brewing in Gotham, and if he wants to save the city from The Joker's hostile takeover, Batman may have to drop the lone vigilante thing, try to work with others and maybe, just maybe, learn to lighten up.",
			ReleaseDate = new DateTime(2017,2,8),
			VoteAverage = 7.2m,
			VoteCount = 1473,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG,
			URL = "http://www.legobatman.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0878804",
			Title = "The Blind Side",
			Description = "Oversized African-American, Michael Oher, the teen from across the tracks and a broken home, has nowhere to sleep at age 16. Taken in by an affluent Memphis couple, Michael embarks on a remarkable rise to play for the NFL.",
			ReleaseDate = new DateTime(2009,11,20),
			VoteAverage = 7.2m,
			VoteCount = 1626,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.theblindsidemovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0075860",
			Title = "Close Encounters of the Third Kind",
			Description = "After an encounter with UFOs, a line worker feels undeniably drawn to an isolated area in the wilderness where something spectacular is about to happen.",
			ReleaseDate = new DateTime(1977,11,16),
			VoteAverage = 7.2m,
			VoteCount = 1122,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0372183",
			Title = "The Bourne Supremacy",
			Description = "When a CIA operation to purchase classified Russian documents is blown by a rival agent, who then shows up in the sleepy seaside village where Bourne and Marie have been living. The pair run for their lives and Bourne, who promised retaliation should anyone from his former life attempt contact, is forced to once again take up his life as a trained assassin to survive.",
			ReleaseDate = new DateTime(2004,7,23),
			VoteAverage = 7.2m,
			VoteCount = 2873,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "https://www.uphe.com/movies/the-bourne-supremacy"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt5052448",
			Title = "Get Out",
			Description = "Chris and his girlfriend Rose go upstate to visit her parents for the weekend. At first, Chris reads the family's overly accommodating behavior as nervous attempts to deal with their daughter's interracial relationship, but as the weekend progresses, a series of increasingly disturbing discoveries lead him to a truth that he never could have imagined.",
			ReleaseDate = new DateTime(2017,2,24),
			VoteAverage = 7.2m,
			VoteCount = 2978,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery"),
			Rating = Rating.R,
			URL = "http://www.getoutfilm.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1403865",
			Title = "True Grit",
			Description = "Following the murder of her father by hired hand Tom Chaney, 14-year-old farm girl Mattie Ross sets out to capture the killer. To aid her, she hires the toughest U.S. Marshal she can find, a man with 'true grit,' Reuben J. 'Rooster' Cogburn. Mattie insists on accompanying Cogburn, whose drinking, sloth, and generally reprobate character do not augment her faith in him. Against his wishes, she joins him in his trek into the Indian Nations in search of Chaney. They are joined by Texas Ranger LaBoeuf, who wants Chaney for his own purposes. The unlikely trio find danger and adventure on the journey, and each has his or her 'grit' tested.",
			ReleaseDate = new DateTime(2010,12,22),
			VoteAverage = 7.2m,
			VoteCount = 1701,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.truegritmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1568346",
			Title = "The Girl with the Dragon Tattoo",
			Description = "This English-language adaptation of the Swedish novel by Stieg Larsson follows a disgraced journalist, Mikael Blomkvist, as he investigates the disappearance of a weary patriarch's niece from 40 years ago. He is aided by the pierced, tattooed, punk computer hacker named Lisbeth Salander. As they work together in the investigation, Blomkvist and Salander uncover immense corruption beyond anything they have ever imagined.",
			ReleaseDate = new DateTime(2011,12,14),
			VoteAverage = 7.2m,
			VoteCount = 2479,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = "http://dragontattoo.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0936501",
			Title = "Taken",
			Description = "While vacationing with a friend in Paris, an American girl is kidnapped by a gang of human traffickers intent on selling her into forced prostitution. Working against the clock, her ex-spy father must pull out all the stops to save her. But with his best years possibly behind him, the job may be more than he can handle.",
			ReleaseDate = new DateTime(2008,2,18),
			VoteAverage = 7.2m,
			VoteCount = 4444,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3890160",
			Title = "Baby Driver",
			Description = "After being coerced into working for a crime boss, a young getaway driver finds himself taking part in a heist doomed to fail.",
			ReleaseDate = new DateTime(2017,6,28),
			VoteAverage = 7.2m,
			VoteCount = 2083,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0110148",
			Title = "Interview with the Vampire",
			Description = "A vampire relates his epic life story of love, betrayal, loneliness, and dark hunger to an over-curious reporter.",
			ReleaseDate = new DateTime(1994,11,11),
			VoteAverage = 7.2m,
			VoteCount = 1558,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0097757",
			Title = "The Little Mermaid",
			Description = "This colorful adventure tells the story of an impetuous mermaid princess named Ariel who falls in love with the very human Prince Eric and puts everything on the line for the chance to be with him. Memorable songs and characters -- including the villainous sea witch Ursula.",
			ReleaseDate = new DateTime(1989,11,17),
			VoteAverage = 7.2m,
			VoteCount = 1921,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2543164",
			Title = "Arrival",
			Description = "Taking place after alien crafts land around the world, an expert linguist is recruited by the military to determine whether they come in peace or are a threat.",
			ReleaseDate = new DateTime(2016,11,10),
			VoteAverage = 7.2m,
			VoteCount = 5729,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.PG13,
			URL = "http://www.arrivalmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0099810",
			Title = "The Hunt for Red October",
			Description = "A new Soviet nuclear missile sub (a Boomer) heading out on her maiden voyage that is being tracked by a Los Angeles class American submarine suddenly goes silent and 'disappears.' This focuses the attention of both U.S. Intelligence and the U.S. Navy on the Russian Sub Commander .  When it is determined that the silent Soviet Boomer may be headed for American coastal waters panic ensues. A CIA analyst, Jack Ryan,  convinces the brass that the Boomer's commander may intend something other than a nuclear first strike in mind. A perilous and tense cat-and-mouse game ensues.",
			ReleaseDate = new DateTime(1990,3,2),
			VoteAverage = 7.2m,
			VoteCount = 971,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG,
			URL = "http://www.paramount.com/movies/hunt-red-october"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0077631",
			Title = "Grease",
			Description = "Australian good girl Sandy and greaser Danny fell in love over the summer. But when they unexpectedly discover they're now in the same high school, will they be able to rekindle their romance despite their eccentric friends?",
			ReleaseDate = new DateTime(1978,7,7),
			VoteAverage = 7.2m,
			VoteCount = 1633,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0265086",
			Title = "Black Hawk Down",
			Description = "When U.S. Rangers and an elite Delta Force team attempt to kidnap two underlings of a Somali warlord, their Black Hawk helicopters are shot down, and the Americans suffer heavy casualties, facing intense fighting from the militia on the ground.",
			ReleaseDate = new DateTime(2001,12,28),
			VoteAverage = 7.2m,
			VoteCount = 1832,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0118884",
			Title = "Contact",
			Description = "Contact is a science fiction film about an encounter with alien intelligence. Based on the novel by Carl Sagan the film starred Jodie Foster as the one chosen scientist who must make some difficult decisions between her beliefs, the truth, and reality.",
			ReleaseDate = new DateTime(1997,7,11),
			VoteAverage = 7.2m,
			VoteCount = 1338,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG,
			URL = "http://www.warnerbros.com/contact"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120917",
			Title = "The Emperor's New Groove",
			Description = "Kuzco is a self-centered emperor who summons Pacha from a village and to tell him that his home will be destroyed to make room for Kuzco's new summer home. Kuzco's advisor, Yzma, tries to poison Kuzco and accidentally turns him into a llama, who accidentally ends up in Pacha's village. Pacha offers to help Kuzco if he doesn't destroy his house, and so they form an unlikely partnership.",
			ReleaseDate = new DateTime(2000,12,9),
			VoteAverage = 7.2m,
			VoteCount = 1544,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3682448",
			Title = "Bridge of Spies",
			Description = "During the Cold War, the Soviet Union captures U.S. pilot Francis Gary Powers after shooting down his U-2 spy plane. Sentenced to 10 years in prison, Powers' only hope is New York lawyer James Donovan, recruited by a CIA operative to negotiate his release. Donovan boards a plane to Berlin, hoping to win the young man's freedom through a prisoner exchange. If all goes well, the Russians would get Rudolf Abel, the convicted spy who Donovan defended in court.",
			ReleaseDate = new DateTime(2015,10,15),
			VoteAverage = 7.2m,
			VoteCount = 2633,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0110322",
			Title = "Legends of the Fall",
			Description = "An epic tale of three brothers and their father living in the remote wilderness of 1900s USA and how their lives are affected by nature, history, war, and love.",
			ReleaseDate = new DateTime(1994,12,16),
			VoteAverage = 7.2m,
			VoteCount = 636,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0401792",
			Title = "Sin City",
			Description = "Welcome to Sin City. This town beckons to the tough, the corrupt, the brokenhearted. Some call it dark, Hard-boiled. Then there are those who call it home: Crooked cops, sexy dames, desperate vigilantes. Some are seeking revenge, others lust after redemption, and then there are those hoping for a little of both. A universe of unlikely and reluctant heroes still trying to do the right thing in a city that refuses to care.",
			ReleaseDate = new DateTime(2005,4,1),
			VoteAverage = 7.2m,
			VoteCount = 2755,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = "http://www.miramax.com/movie/sin-city/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0118971",
			Title = "The Devil's Advocate",
			Description = "A hotshot lawyer gets more than he bargained for when he learns his new boss is Lucifer himself.",
			ReleaseDate = new DateTime(1997,10,17),
			VoteAverage = 7.2m,
			VoteCount = 1414,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0486655",
			Title = "Stardust",
			Description = "In a countryside town bordering on a magical land, a young man makes a promise to his beloved that he'll retrieve a fallen star by venturing into the magical realm. His journey takes him into a world beyond his wildest dreams and reveals his true identity.",
			ReleaseDate = new DateTime(2007,8,9),
			VoteAverage = 7.2m,
			VoteCount = 1215,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.stardustmovie.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0107808",
			Title = "A Perfect World",
			Description = "A kidnapped boy strikes up a friendship with his captor: an escaped convict on the run from the law, headed by an honorable U.S. Marshal.",
			ReleaseDate = new DateTime(1993,11,24),
			VoteAverage = 7.2m,
			VoteCount = 376,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0114388",
			Title = "Sense and Sensibility",
			Description = "Rich Mr. Dashwood dies, leaving his second wife and her daughters poor by the rules of inheritance. Two daughters are the titular opposites.",
			ReleaseDate = new DateTime(1995,12,13),
			VoteAverage = 7.2m,
			VoteCount = 364,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1197624",
			Title = "Law Abiding Citizen",
			Description = "A frustrated man decides to take justice into his own hands after a plea bargain sets one of his family's killers free. He targets not only the killer but also the district attorney and others involved in the deal.",
			ReleaseDate = new DateTime(2009,10,15),
			VoteAverage = 7.2m,
			VoteCount = 1522,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0083944",
			Title = "First Blood",
			Description = "When former Green Beret John Rambo is harassed by local law enforcement and arrested for vagrancy, the Vietnam vet snaps, runs for the hills and rat-a-tat-tats his way into the action-movie hall of fame. Hounded by a relentless sheriff, Rambo employs heavy-handed guerilla tactics to shake the cops off his tail.",
			ReleaseDate = new DateTime(1982,10,22),
			VoteAverage = 7.2m,
			VoteCount = 1523,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0058150",
			Title = "Goldfinger",
			Description = "Special agent 007 (Sean Connery) comes face to face with one of the most notorious villains of all time, and now he must outwit and outgun the powerful tycoon to prevent him from cashing in on a devious scheme to raid Fort Knox -- and obliterate the world's economy.",
			ReleaseDate = new DateTime(1964,9,17),
			VoteAverage = 7.2m,
			VoteCount = 1005,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG,
			URL = "http://www.mgm.com/view/movie/760/Goldfinger/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0350258",
			Title = "Ray",
			Description = "Born on a sharecropping plantation in Northern Florida, Ray Charles went blind at seven. Inspired by a fiercely independent mom who insisted he make his own way, He found his calling and his gift behind a piano keyboard. Touring across the Southern musical circuit, the soulful singer gained a reputation and then exploded with worldwide fame when he pioneered couping gospel and country together.",
			ReleaseDate = new DateTime(2004,10,29),
			VoteAverage = 7.2m,
			VoteCount = 481,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0071230",
			Title = "Blazing Saddles",
			Description = "A town,  where everyone seems to be named Johnson, is in the way of the railroad and, in order to grab their land, Hedley Lemar, a politically connected nasty person, sends in his henchmen to make the town unlivable. After the sheriff is killed, the town demands a new sheriff from the Governor, so Hedley convinces him to send the town the first black sheriff in the west.",
			ReleaseDate = new DateTime(1974,2,7),
			VoteAverage = 7.2m,
			VoteCount = 619,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0121164",
			Title = "Corpse Bride",
			Description = "Set in a 19th-century european village, this stop-motion animation feature follows the story of Victor, a young man whisked away to the underworld and wed to a mysterious corpse bride, while his real bride Victoria waits bereft in the land of the living.",
			ReleaseDate = new DateTime(2005,9,9),
			VoteAverage = 7.2m,
			VoteCount = 1957,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://corpsebridemovie.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0308644",
			Title = "Finding Neverland",
			Description = "Finding Neverland is an amusing drama about how the story of Peter Pan and Neverland came to be. During a writing slump play writer J.M. Barrie meets the widowed Sylvia and her three children who soon become an important part of Barrie's life and the inspiration that lead him to create his masterpiece, Peter Pan.",
			ReleaseDate = new DateTime(2004,10,17),
			VoteAverage = 7.2m,
			VoteCount = 1269,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1327773",
			Title = "The Butler",
			Description = "A look at the life of Cecil Gaines who served eight presidents as the White House's head butler from 1952 to 1986, and had a unique front-row seat as political and racial history was made.",
			ReleaseDate = new DateTime(2013,8,16),
			VoteAverage = 7.2m,
			VoteCount = 1134,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0976051",
			Title = "The Reader",
			Description = "The story of Michael Berg, a German lawyer who, as a teenager in the late 1950s, had an affair with an older woman, Hanna, who then disappeared only to resurface years later as one of the defendants in a war crimes trial stemming from her actions as a concentration camp guard late in the war. He alone realizes that Hanna is illiterate and may be concealing that fact at the expense of her freedom.",
			ReleaseDate = new DateTime(2008,12,10),
			VoteAverage = 7.2m,
			VoteCount = 835,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0133240",
			Title = "Treasure Planet",
			Description = "When space galleon cabin boy Jim Hawkins discovers a map to an intergalactic 'loot of a thousand worlds,' a cyborg cook named John Silver teaches him to battle supernovas and space storms. But, soon, Jim realizes Silver is a pirate intent on mutiny!",
			ReleaseDate = new DateTime(2002,11,26),
			VoteAverage = 7.2m,
			VoteCount = 980,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0387564",
			Title = "Saw",
			Description = "Obsessed with teaching his victims the value of life, a deranged, sadistic serial killer abducts the morally wayward. Once captured, they must face impossible choices in a horrific game of survival. The victims must fight to win their lives back, or die trying...",
			ReleaseDate = new DateTime(2004,10,1),
			VoteAverage = 7.2m,
			VoteCount = 2255,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1156398",
			Title = "Zombieland",
			Description = "Columbus has made a habit of running from what scares him. Tallahassee doesn't have fears. If he did, he'd kick their ever-living ass. In a world overrun by zombies, these two are perfectly evolved survivors. But now, they're about to stare down the most terrifying prospect of all: each other.",
			ReleaseDate = new DateTime(2009,10,7),
			VoteAverage = 7.2m,
			VoteCount = 3655,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.R,
			URL = "http://www.zombieland.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2820852",
			Title = "Furious 7",
			Description = "Deckard Shaw seeks revenge against Dominic Toretto and his family for his comatose brother.",
			ReleaseDate = new DateTime(2015,4,1),
			VoteAverage = 7.3m,
			VoteCount = 4253,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.furious7.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2395427",
			Title = "Avengers: Age of Ultron",
			Description = "When Tony Stark tries to jumpstart a dormant peacekeeping program, things go awry and Earth's Mightiest Heroes are put to the ultimate test as the fate of the planet hangs in the balance. As the villainous Ultron emerges, it is up to The Avengers to stop him from enacting his terrible plans, and soon uneasy alliances and unexpected action pave the way for an epic and unique global adventure.",
			ReleaseDate = new DateTime(2015,4,22),
			VoteAverage = 7.3m,
			VoteCount = 6908,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://marvel.com/movies/movie/193/avengers_age_of_ultron"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2294629",
			Title = "Frozen",
			Description = "Young princess Anna of Arendelle dreams about finding true love at her sister Elsa's coronation. Fate takes her on a dangerous journey in an attempt to end the eternal winter that has fallen over the kingdom. She's accompanied by ice delivery man Kristoff, his reindeer Sven, and snowman Olaf. On an adventure where she will find out what friendship, courage, family, and true love really means.",
			ReleaseDate = new DateTime(2013,11,27),
			VoteAverage = 7.3m,
			VoteCount = 5440,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://movies.disney.com/frozen"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0083866",
			Title = "E.T. the Extra-Terrestrial",
			Description = "After a gentle alien becomes stranded on Earth, the being is discovered and befriended by a young boy named Elliott. Bringing the extraterrestrial into his suburban California house, Elliott introduces E.T., as the alien is dubbed, to his brother and his little sister, Gertie, and the children decide to keep its existence a secret. Soon, however, E.T. falls ill, resulting in government intervention and a dire situation for both Elliott and the alien.",
			ReleaseDate = new DateTime(1982,4,3),
			VoteAverage = 7.3m,
			VoteCount = 3359,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG,
			URL = "http://www.et20.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1454468",
			Title = "Gravity",
			Description = "Dr. Ryan Stone, a brilliant medical engineer on her first Shuttle mission, with veteran astronaut Matt Kowalsky in command of his last flight before retiring. But on a seemingly routine spacewalk, disaster strikes. The Shuttle is destroyed, leaving Stone and Kowalsky completely alone-tethered to nothing but each other and spiraling out into the blackness of space. The deafening silence tells them they have lost any link to Earth and any chance for rescue. As fear turns to panic, every gulp of air eats away at what little oxygen is left. But the only way home may be to go further out into the terrifying expanse of space.",
			ReleaseDate = new DateTime(2013,9,27),
			VoteAverage = 7.3m,
			VoteCount = 5879,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG13,
			URL = "http://gravitymovie.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2103281",
			Title = "Dawn of the Planet of the Apes",
			Description = "A group of scientists in San Francisco struggle to stay alive in the aftermath of a plague that is wiping out humanity, while Caesar tries to maintain dominance over his community of intelligent apes.",
			ReleaseDate = new DateTime(2014,6,26),
			VoteAverage = 7.3m,
			VoteCount = 4511,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG13,
			URL = "http://www.dawnofapes.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3521164",
			Title = "Moana",
			Description = "In Ancient Polynesia, when a terrible curse incurred by Maui reaches an impetuous Chieftain's daughter's island, she answers the Ocean's call to seek out the demigod to set things right.",
			ReleaseDate = new DateTime(2016,11,23),
			VoteAverage = 7.3m,
			VoteCount = 3471,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://movies.disney.com/moana"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0381061",
			Title = "Casino Royale",
			Description = "Le Chiffre, a banker to the world's terrorists, is scheduled to participate in a high-stakes poker game in Montenegro, where he intends to use his winnings to establish his financial grip on the terrorist market. M sends Bond (on his maiden mission as a 00 Agent) to attend this game and prevent Le Chiffre from winning. With the help of Vesper Lynd and Felix Leiter, Bond enters the most important poker game in his already dangerous career.",
			ReleaseDate = new DateTime(2006,11,14),
			VoteAverage = 7.3m,
			VoteCount = 3930,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.mgm.com/#/our-titles/233/Casino-Royale-(2006)"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1663202",
			Title = "The Revenant",
			Description = "In the 1820s, a frontiersman, Hugh Glass, sets out on a path of vengeance against those who left him for dead after a bear mauling.",
			ReleaseDate = new DateTime(2015,12,25),
			VoteAverage = 7.3m,
			VoteCount = 6558,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Western"),
			Rating = Rating.R,
			URL = "http://www.foxmovies.com/movies/the-revenant"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120363",
			Title = "Toy Story 2",
			Description = "Andy heads off to Cowboy Camp, leaving his toys to their own devices. Things shift into high gear when an obsessive toy collector named Al McWhiggen, owner of Al's Toy Barn kidnaps Woody. Andy's toys mount a daring rescue mission, Buzz Lightyear meets his match and Woody has to decide where he and his heart truly belong.",
			ReleaseDate = new DateTime(1999,10,30),
			VoteAverage = 7.3m,
			VoteCount = 3914,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = "http://toystory.disney.com/toy-story-2"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0126029",
			Title = "Shrek",
			Description = "It ain't easy bein' green -- especially if you're a likable (albeit smelly) ogre named Shrek. On a mission to retrieve a gorgeous princess from the clutches of a fire-breathing dragon, Shrek teams up with an unlikely compatriot -- a wisecracking donkey.",
			ReleaseDate = new DateTime(2001,5,16),
			VoteAverage = 7.3m,
			VoteCount = 4183,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://www.shrek.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0325710",
			Title = "The Last Samurai",
			Description = "Nathan Algren is an American hired to instruct the Japanese army in the ways of modern warfare, which finds him learning to respect the samurai and the honorable principles that rule them. Pressed to destroy the samurai's way of life in the name of modernization and open trade, Algren decides to become an ultimate warrior himself and to fight for their right to exist.",
			ReleaseDate = new DateTime(2003,12,5),
			VoteAverage = 7.3m,
			VoteCount = 1946,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0440963",
			Title = "The Bourne Ultimatum",
			Description = "Bourne is brought out of hiding once again by reporter Simon Ross who is trying to unveil Operation Blackbriar, an upgrade to Project Treadstone, in a series of newspaper columns. Information from the reporter stirs a new set of memories, and Bourne must finally uncover his dark past while dodging The Company's best efforts to eradicate him.",
			ReleaseDate = new DateTime(2007,8,3),
			VoteAverage = 7.3m,
			VoteCount = 2938,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.universalstudiosentertainment.com/the-bourne-ultimatum/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1392190",
			Title = "Mad Max: Fury Road",
			Description = "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and most everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order. There's Max, a man of action and a man of few words, who seeks peace of mind following the loss of his wife and child in the aftermath of the chaos. And Furiosa, a woman of action and a woman who believes her path to survival may be achieved if she can make it across the desert back to her childhood homeland.",
			ReleaseDate = new DateTime(2015,5,13),
			VoteAverage = 7.3m,
			VoteCount = 9629,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = "http://www.madmaxmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0112384",
			Title = "Apollo 13",
			Description = "The true story of technical troubles that scuttle the Apollo 13 lunar mission in 1971, risking the lives of astronaut Jim Lovell and his crew, with the failed journey turning into a thrilling saga of heroism. Drifting more than 200,000 miles from Earth, the astronauts work furiously with the ground crew to avert tragedy.",
			ReleaseDate = new DateTime(1995,6,30),
			VoteAverage = 7.3m,
			VoteCount = 1637,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1343092",
			Title = "The Great Gatsby",
			Description = "An adaptation of F. Scott Fitzgerald's Long Island-set novel, where Midwesterner Nick Carraway is lured into the lavish world of his neighbor, Jay Gatsby. Soon enough, however, Carraway will see through the cracks of Gatsby's nouveau riche existence, where obsession, madness, and tragedy await.",
			ReleaseDate = new DateTime(2013,5,10),
			VoteAverage = 7.3m,
			VoteCount = 3885,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0421715",
			Title = "The Curious Case of Benjamin Button",
			Description = "Tells the story of Benjamin Button, a man who starts aging backwards with bizarre consequences.",
			ReleaseDate = new DateTime(2008,11,24),
			VoteAverage = 7.3m,
			VoteCount = 3398,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = "http://www.benjaminbutton.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0947798",
			Title = "Black Swan",
			Description = "A ballet dancer wins the lead in 'Swan Lake' and is perfect for the role of the delicate White Swan - Princess Odette - but slowly loses her mind as she becomes more and more like Odile, the Black Swan.",
			ReleaseDate = new DateTime(2010,12,2),
			VoteAverage = 7.3m,
			VoteCount = 4562,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = "http://www.foxsearchlight.com/blackswan/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0087332",
			Title = "Ghostbusters",
			Description = "After losing their academic posts at a prestigious university, a team of parapsychologists goes into business as proton-pack-toting 'ghostbusters' who exterminate ghouls, hobgoblins and supernatural pests of all stripes. An ad campaign pays off when a knockout cellist hires the squad to purge her swanky digs of demons that appear to be living in her refrigerator.",
			ReleaseDate = new DateTime(1984,6,7),
			VoteAverage = 7.3m,
			VoteCount = 2431,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG,
			URL = "http://www.ghostbusters.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0119116",
			Title = "The Fifth Element",
			Description = "In 2257, a taxi driver is unintentionally given the task of saving a young girl who is part of the key that will ensure the survival of humanity.",
			ReleaseDate = new DateTime(1997,5,7),
			VoteAverage = 7.3m,
			VoteCount = 3962,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0119282",
			Title = "Hercules",
			Description = "Bestowed with superhuman strength, a young mortal named Hercules sets out to prove himself a hero in the eyes of his father, the great god Zeus. Along with his friends Pegasus, a flying horse, and Phil, a personal trainer, Hercules is tricked by the hilarious, hotheaded villain Hades, who's plotting to take over Mount Olympus!",
			ReleaseDate = new DateTime(1997,6,26),
			VoteAverage = 7.3m,
			VoteCount = 1741,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0258463",
			Title = "The Bourne Identity",
			Description = "Wounded to the brink of death and suffering from amnesia, Jason Bourne is rescued at sea by a fisherman. With nothing to go on but a Swiss bank account number, he starts to reconstruct his life, but finds that many people he encounters want him dead. However, Bourne realizes that he has the combat and mental skills of a world-class spy, but who does he work for?",
			ReleaseDate = new DateTime(2002,6,14),
			VoteAverage = 7.3m,
			VoteCount = 3640,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.universalstudiosentertainment.com/the-bourne-identity/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1136608",
			Title = "District 9",
			Description = "Aliens land in South Africa and, with their ship totally disabled,  have no way home. Years later, after living in a slum and wearing out their welcome the 'Non-Humans' are being moved to a new tent city overseen by Multi-National United (MNU).",
			ReleaseDate = new DateTime(2009,8,5),
			VoteAverage = 7.3m,
			VoteCount = 3451,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.R,
			URL = "http://www.d-9.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0358273",
			Title = "Walk the Line",
			Description = "A chronicle of country music legend Johnny Cash's life, from his early days on an Arkansas cotton farm to his rise to fame with Sun Records in Memphis, where he recorded alongside Elvis Presley, Jerry Lee Lewis and Carl Perkins.",
			ReleaseDate = new DateTime(2005,9,13),
			VoteAverage = 7.3m,
			VoteCount = 732,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0454848",
			Title = "Inside Man",
			Description = "Bank robber Dalton Russell enters a Manhattan bank, locks the doors and takes hostages, working methodically and without haste. Detective Frazier is assigned to negotiate, but his mind is occupied with the corruption charges he is facing. With an army of police surrounding the bank, the thief, the cop and a high-profile 'fixer' enter high-stakes negotiations.",
			ReleaseDate = new DateTime(2006,3,23),
			VoteAverage = 7.3m,
			VoteCount = 1671,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://theinsideman.net"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0112579",
			Title = "The Bridges of Madison County",
			Description = "Photographer Robert Kincaid wanders into the life of housewife Francesca Johnson for four days in the 1960s.",
			ReleaseDate = new DateTime(1995,5,28),
			VoteAverage = 7.3m,
			VoteCount = 397,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0257044",
			Title = "Road to Perdition",
			Description = "Mike Sullivan works as a hit man for crime boss John Rooney. Sullivan views Rooney as a father figure, however after his son is witness to a killing, Mike Sullivan finds himself on the run in attempt to save the life of his son and at the same time looking for revenge on those who wronged him.",
			ReleaseDate = new DateTime(2002,7,12),
			VoteAverage = 7.3m,
			VoteCount = 1102,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3076658",
			Title = "Creed",
			Description = "The former World Heavyweight Champion Rocky Balboa serves as a trainer and mentor to Adonis Johnson, the son of his late friend and former rival Apollo Creed.",
			ReleaseDate = new DateTime(2015,11,25),
			VoteAverage = 7.3m,
			VoteCount = 1963,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://creedthemovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0117665",
			Title = "Sleepers",
			Description = "Two gangsters seek revenge on the state jail worker who during their stay at a youth prison sexually abused them. A sensational court hearing takes place to charge him for the crimes. A moving drama from director Barry Levinson.",
			ReleaseDate = new DateTime(1996,10,18),
			VoteAverage = 7.3m,
			VoteCount = 729,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1809398",
			Title = "Unbroken",
			Description = "A chronicle of the life of Louis Zamperini, an Olympic runner who was taken prisoner by Japanese forces during World War II.",
			ReleaseDate = new DateTime(2014,12,25),
			VoteAverage = 7.3m,
			VoteCount = 1437,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.unbrokenfilm.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0397535",
			Title = "Memoirs of a Geisha",
			Description = "A sweeping romantic epic set in Japan in the years before World War II, a penniless Japanese child is torn from her family to work as a maid in a geisha house.",
			ReleaseDate = new DateTime(2005,12,6),
			VoteAverage = 7.3m,
			VoteCount = 670,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.sonypictures.com/homevideo/memoirsofageisha/index.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0105323",
			Title = "Scent of a Woman",
			Description = "Charlie Simms (Chris O'Donnell) is a student at a private preparatory school who comes from a poor family. To earn the money for his flight home to Gresham, Oregon for Christmas, Charlie takes a job over Thanksgiving looking after retired U.S. Army officer Lieutenant Colonel Frank Slade (Al Pacino), a cantankerous middle-aged man who lives with his niece and her family.",
			ReleaseDate = new DateTime(1992,12,23),
			VoteAverage = 7.3m,
			VoteCount = 763,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1655442",
			Title = "The Artist",
			Description = "Hollywood, 1927: As silent movie star George Valentin wonders if the arrival of talking pictures will cause him to fade into oblivion, he sparks with Peppy Miller, a young dancer set for a big break.",
			ReleaseDate = new DateTime(2011,5,15),
			VoteAverage = 7.3m,
			VoteCount = 1075,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.warnerbros.fr/the-artist"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1596363",
			Title = "The Big Short",
			Description = "The men who made millions from a global economic meltdown.",
			ReleaseDate = new DateTime(2015,12,11),
			VoteAverage = 7.3m,
			VoteCount = 2679,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.R,
			URL = "http://www.thebigshortmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0328107",
			Title = "Man on Fire",
			Description = "Jaded ex-CIA operative John Creasy reluctantly accepts a job as the bodyguard for a 10-year-old girl in Mexico City. They clash at first, but eventually bond, and when she's kidnapped he's consumed by fury and will stop at nothing to save her life.",
			ReleaseDate = new DateTime(2004,4,23),
			VoteAverage = 7.3m,
			VoteCount = 1583,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0327597",
			Title = "Coraline",
			Description = "When Coraline moves to an old house, she feels bored and neglected by her parents. She finds a hidden door with a bricked up passage. During the night, she crosses the passage and finds a parallel world where everybody has buttons instead of eyes, with caring parents and all her dreams coming true. When the Other Mother invites Coraline to stay in her world forever, the girl refuses and finds that the alternate reality where she is trapped is only a trick to lure her.",
			ReleaseDate = new DateTime(2009,2,5),
			VoteAverage = 7.3m,
			VoteCount = 1432,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://coraline.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0472043",
			Title = "Apocalypto",
			Description = "Set in the Mayan civilization, when a man's idyllic presence is brutally disrupted by a violent invading force, he is taken on a perilous journey to a world ruled by fear and oppression where a harrowing end awaits him. Through a twist of fate and spurred by the power of his love for his woman and his family he will make a desperate break to return home and to ultimately save his way of life.",
			ReleaseDate = new DateTime(2006,12,7),
			VoteAverage = 7.3m,
			VoteCount = 1252,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0335266",
			Title = "Lost in Translation",
			Description = "Two lost souls visiting Tokyo -- the young, neglected wife of a photographer and a washed-up movie star shooting a TV commercial -- find an odd solace and pensive freedom to be real in each other's company, away from their lives in America.",
			ReleaseDate = new DateTime(2003,8,31),
			VoteAverage = 7.3m,
			VoteCount = 1943,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1670345",
			Title = "Now You See Me",
			Description = "An FBI agent and an Interpol detective track a team of illusionists who pull off bank heists during their performances and reward their audiences with the money.",
			ReleaseDate = new DateTime(2013,5,29),
			VoteAverage = 7.3m,
			VoteCount = 5635,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1981677",
			Title = "Pitch Perfect",
			Description = "College student Beca knows she does not want to be part of a clique, but that's exactly where she finds herself after arriving at her new school. Thrust in among mean gals, nice gals and just plain weird gals, Beca finds that the only thing they have in common is how well they sing together. She takes the women of the group out of their comfort zone of traditional arrangements and into a world of amazing harmonic combinations in a fight to the top of college music competitions.",
			ReleaseDate = new DateTime(2012,9,28),
			VoteAverage = 7.3m,
			VoteCount = 2310,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.PG13,
			URL = "http://www.pitchperfectmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0824747",
			Title = "Changeling",
			Description = "Christine Collins is overjoyed when her kidnapped son is brought back home. But when Christine suspects that the boy returned to her isn't her child, the police captain has her committed to an asylum.",
			ReleaseDate = new DateTime(2008,1,30),
			VoteAverage = 7.3m,
			VoteCount = 1151,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://www.changelingmovie.net"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2140373",
			Title = "Saving Mr. Banks",
			Description = "Author P.L. Travers travels from London to Hollywood as Walt Disney Pictures adapts her novel Mary Poppins for the big screen.",
			ReleaseDate = new DateTime(2013,11,16),
			VoteAverage = 7.3m,
			VoteCount = 1256,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0352248",
			Title = "Cinderella Man",
			Description = "The true story of boxer, Jim Braddock who, in the 1920s after his retirement, has a surprise comeback in order to get him and his family out of a socially poor state.",
			ReleaseDate = new DateTime(2005,6,2),
			VoteAverage = 7.3m,
			VoteCount = 630,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG13,
			URL = "http://www.cinderellamanmovie.com/index.php"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0139654",
			Title = "Training Day",
			Description = "On his first day on the job as a narcotics officer, a rookie cop works with a rogue detective who isn't what he appears.",
			ReleaseDate = new DateTime(2001,10,5),
			VoteAverage = 7.3m,
			VoteCount = 1665,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0076095",
			Title = "The Goodbye Girl",
			Description = "Paula McFadden knows: In romance, actors all follow the same stage instruction: Exit. Without warning, her actor boyfriend split today for a movie role and sublet their Manhattan apartment. The new tenant's name: Elliot Garfield. Profession: actor. Richard Dreyfuss and Marsha Mason deliver comedy, zingy repartee and bitter-to-best romance in The Goodbye Girl.",
			ReleaseDate = new DateTime(1977,11,30),
			VoteAverage = 7.3m,
			VoteCount = 37,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0848228",
			Title = "The Avengers",
			Description = "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!",
			ReleaseDate = new DateTime(2012,4,25),
			VoteAverage = 7.4m,
			VoteCount = 12000,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://marvel.com/avengers_movie/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3748528",
			Title = "Rogue One: A Star Wars Story",
			Description = "A rogue band of resistance fighters unite for a mission to steal the Death Star plans and bring a new hope to the galaxy.",
			ReleaseDate = new DateTime(2016,12,14),
			VoteAverage = 7.4m,
			VoteCount = 5111,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.starwars.com/films/rogue-one"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0373889",
			Title = "Harry Potter and the Order of the Phoenix",
			Description = "Returning for his fifth year of study at Hogwarts, Harry is stunned to find that his warnings about the return of Lord Voldemort have been ignored. Left with no choice, Harry takes matters into his own hands, training a small group of students dubbed 'Dumbledore's Army' to defend themselves against the dark arts.",
			ReleaseDate = new DateTime(2007,6,28),
			VoteAverage = 7.4m,
			VoteCount = 5633,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = "http://www.harrypotterorderofthephoenix.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0417741",
			Title = "Harry Potter and the Half-Blood Prince",
			Description = "As Harry begins his sixth year at Hogwarts, he discovers an old book marked as 'Property of the Half-Blood Prince', and begins to learn more about Lord Voldemort's dark past.",
			ReleaseDate = new DateTime(2009,7,7),
			VoteAverage = 7.4m,
			VoteCount = 5435,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG,
			URL = "http://harrypotter.warnerbros.com/harrypotterandthehalf-bloodprince/dvd/index.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0295297",
			Title = "Harry Potter and the Chamber of Secrets",
			Description = "Ignoring threats to his life, Harry returns to Hogwarts to investigate a mysterious series of attacks.",
			ReleaseDate = new DateTime(2002,11,13),
			VoteAverage = 7.4m,
			VoteCount = 5966,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1951264",
			Title = "The Hunger Games: Catching Fire",
			Description = "Katniss Everdeen has returned home safe after winning the 74th Annual Hunger Games along with fellow tribute Peeta Mellark. Winning means that they must turn around and leave their family and close friends, embarking on a 'Victor's Tour' of the districts. Along the way Katniss senses that a rebellion is simmering, but the Capitol is still very much in control as President Snow prepares the 75th Annual Hunger Games (The Quarter Quell) - a competition that could change Panem forever.",
			ReleaseDate = new DateTime(2013,11,15),
			VoteAverage = 7.4m,
			VoteCount = 6656,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.thehungergames.movie/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1431045",
			Title = "Deadpool",
			Description = "Deadpool tells the origin story of former Special Forces operative turned mercenary Wade Wilson, who after being subjected to a rogue experiment that leaves him with accelerated healing powers, adopts the alter ego Deadpool. Armed with his new abilities and a dark, twisted sense of humor, Deadpool hunts down the man who nearly destroyed his life.",
			ReleaseDate = new DateTime(2016,2,9),
			VoteAverage = 7.4m,
			VoteCount = 11444,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = "http://www.foxmovies.com/movies/deadpool"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0317705",
			Title = "The Incredibles",
			Description = "Bob Parr has given up his superhero days to log in time as an insurance adjuster and raise his three children with his formerly heroic wife in suburbia. But when he receives a mysterious assignment, it's time to get back into costume.",
			ReleaseDate = new DateTime(2004,11,5),
			VoteAverage = 7.4m,
			VoteCount = 5290,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://disney.go.com/disneyvideos/animatedfilms/incredibles/main.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0398286",
			Title = "Tangled",
			Description = "When the kingdom's most wanted-and most charming-bandit Flynn Rider hides out in a mysterious tower, he's taken hostage by Rapunzel, a beautiful and feisty tower-bound teen with 70 feet of magical, golden hair. Flynn's curious captor, who's looking for her ticket out of the tower where she's been locked away for years, strikes a deal with the handsome thief and the unlikely duo sets off on an action-packed escapade, complete with a super-cop horse, an over-protective chameleon and a gruff gang of pub thugs.",
			ReleaseDate = new DateTime(2010,11,24),
			VoteAverage = 7.4m,
			VoteCount = 3419,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://disney.go.com/disneypictures/tangled/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0371746",
			Title = "Iron Man",
			Description = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",
			ReleaseDate = new DateTime(2008,4,30),
			VoteAverage = 7.4m,
			VoteCount = 8951,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.ironmanmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2179136",
			Title = "American Sniper",
			Description = "U.S. Navy SEAL Chris Kyle takes his sole mission - protect his comrades - to heart and becomes one of the most lethal snipers in American history. His pinpoint accuracy not only saves countless lives but also makes him a prime target of insurgents. Despite grave danger and his struggle to be a good husband and father to his family back in the States, Kyle serves four tours of duty in Iraq. However, when he finally returns home, he finds that he cannot leave the war behind.",
			ReleaseDate = new DateTime(2014,12,11),
			VoteAverage = 7.4m,
			VoteCount = 4600,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = "http://www.americansnipermovie.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0103639",
			Title = "Aladdin",
			Description = "Princess Jasmine grows tired of being forced to remain in the palace and she sneaks out into the marketplace  in disguise where she meets street-urchin Aladdin and the two fall in love, although she may only marry a prince. After being thrown in jail, Aladdin and becomes embroiled in a plot to find a mysterious lamp with which the evil Jafar hopes to rule the land.",
			ReleaseDate = new DateTime(1992,11,25),
			VoteAverage = 7.4m,
			VoteCount = 3495,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://movies.disney.com/aladdin"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1408101",
			Title = "Star Trek Into Darkness",
			Description = "When the crew of the Enterprise is called back home, they find an unstoppable force of terror from within their own organization has detonated the fleet and everything it stands for, leaving our world in a state of crisis.  With a personal score to settle, Captain Kirk leads a manhunt to a war-zone world to capture a one man weapon of mass destruction. As our heroes are propelled into an epic chess game of life and death, love will be challenged, friendships will be torn apart, and sacrifices must be made for the only family Kirk has left: his crew.",
			ReleaseDate = new DateTime(2013,5,5),
			VoteAverage = 7.4m,
			VoteCount = 4479,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0796366",
			Title = "Star Trek",
			Description = "The fate of the galaxy rests in the hands of bitter rivals. One, James Kirk, is a delinquent, thrill-seeking Iowa farm boy. The other, Spock, a Vulcan, was raised in a logic-based society that rejects all emotion. As fiery instinct clashes with calm reason, their unlikely but powerful partnership is the only thing capable of leading their crew through unimaginable danger, boldly going where no one has gone before. The human adventure has begun again.",
			ReleaseDate = new DateTime(2009,5,6),
			VoteAverage = 7.4m,
			VoteCount = 4574,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0096874",
			Title = "Back to the Future Part II",
			Description = "Marty and Doc are at it again in this wacky sequel to the 1985 blockbuster as the time-traveling duo head to 2015 to nip some McFly family woes in the bud. But things go awry thanks to bully Biff Tannen and a pesky sports almanac. In a last-ditch attempt to set things straight, Marty finds himself bound for 1955 and face to face with his teenage parents -- again.",
			ReleaseDate = new DateTime(1989,11,20),
			VoteAverage = 7.4m,
			VoteCount = 3926,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = "http://www.backtothefuture.com/movies/backtothefuture2"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1457767",
			Title = "The Conjuring",
			Description = "Paranormal investigators Ed and Lorraine Warren work to help a family terrorized by a dark presence in their farmhouse. Forced to confront a powerful entity, the Warrens find themselves caught in the most terrifying case of their lives.",
			ReleaseDate = new DateTime(2013,7,18),
			VoteAverage = 7.4m,
			VoteCount = 3169,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.R,
			URL = "http://theconjuring.warnerbros.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0059742",
			Title = "The Sound of Music",
			Description = "Film adaptation of a classic Rodgers and Hammerstein musical based on a nun who becomes a governess for an Austrian family.",
			ReleaseDate = new DateTime(1965,3,2),
			VoteAverage = 7.4m,
			VoteCount = 966,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0765429",
			Title = "American Gangster",
			Description = "Following the death of his employer and mentor, Bumpy Johnson, Frank Lucas establishes himself as the number one importer of heroin in the Harlem district of Manhattan. He does so by buying heroin directly from the source in South East Asia and he comes up with a unique way of importing the drugs into the United States. Based on a true story.",
			ReleaseDate = new DateTime(2007,11,2),
			VoteAverage = 7.4m,
			VoteCount = 1527,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.americangangster.net/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2713180",
			Title = "Fury",
			Description = "Last months of World War II in April 1945. As the Allies make their final push in the European Theater, a battle-hardened U.S. Army sergeant in the 2nd Armored Division named Wardaddy commands a Sherman tank called 'Fury' and its five-man crew on a deadly mission behind enemy lines. Outnumbered and outgunned, Wardaddy and his men face overwhelming odds in their heroic attempts to strike at the heart of Nazi Germany.",
			ReleaseDate = new DateTime(2014,10,15),
			VoteAverage = 7.4m,
			VoteCount = 4028,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt5362988",
			Title = "Wind River",
			Description = "An FBI agent teams with the town's veteran game tracker to investigate a murder that occurred on a Native American reservation.",
			ReleaseDate = new DateTime(2017,8,3),
			VoteAverage = 7.4m,
			VoteCount = 181,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0203009",
			Title = "Moulin Rouge!",
			Description = "A celebration of love and creative inspiration takes place in the infamous, gaudy and glamorous Parisian nightclub, at the cusp of the 20th century. A young poet, who is plunged into the heady world of Moulin Rouge, begins a passionate affair with the club's most notorious and beautiful star.",
			ReleaseDate = new DateTime(2001,3,9),
			VoteAverage = 7.4m,
			VoteCount = 1348,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0450259",
			Title = "Blood Diamond",
			Description = "An ex-mercenary turned smuggler. A Mende fisherman. Amid the explosive civil war overtaking 1999 Sierra Leone, these men join for two desperate missions: recovering a rare pink diamond of immense value and rescuing the fisherman's son conscripted as a child soldier into the brutal rebel forces ripping a swath of torture and bloodshed countrywide.",
			ReleaseDate = new DateTime(2006,12,7),
			VoteAverage = 7.4m,
			VoteCount = 2344,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0114746",
			Title = "Twelve Monkeys",
			Description = "In the year 2035, convict James Cole reluctantly volunteers to be sent back in time to discover the origin of a deadly virus that wiped out nearly all of the earth's population and forced the survivors into underground communities. But when Cole is mistakenly sent to 1990 instead of 1996, he's arrested and locked up in a mental hospital. There he meets psychiatrist Dr. Kathryn Railly, and patient Jeffrey Goines, the son of a famous virus expert, who may hold the key to the mysterious rogue group, the Army of the 12 Monkeys, thought to be responsible for unleashing the killer disease.",
			ReleaseDate = new DateTime(1995,12,29),
			VoteAverage = 7.4m,
			VoteCount = 2470,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1605783",
			Title = "Midnight in Paris",
			Description = "A romantic comedy about a family traveling to the French capital for business. The party includes a young engaged couple forced to confront the illusion that a life different from their own is better.",
			ReleaseDate = new DateTime(2011,5,11),
			VoteAverage = 7.4m,
			VoteCount = 2049,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = "http://www.sonyclassics.com/midnightinparis"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1091191",
			Title = "Lone Survivor",
			Description = "Based on the failed June 28, 2005 mission 'Operation Red Wing.' Four members of SEAL Team 10, were tasked with the mission to capture or kill notorious Taliban leader, Ahmad Shah. Only one member of the team survived.",
			ReleaseDate = new DateTime(2013,12,24),
			VoteAverage = 7.4m,
			VoteCount = 1549,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = "http://www.lonesurvivorfilm.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0118617",
			Title = "Anastasia",
			Description = "This animated adventure retells the story of the lost daughter of Russia's last czar. The evil Rasputin places a curse on the Romanov family, and Anastasia and her grandmother, Empress Maria, get separated. After growing up in an orphanage, Anastasia encounters two Russian men seeking a reward offered by Empress Maria for the return of her granddaughter. The trio travels to Paris, where they find that the empress has grown skeptical of imposters.",
			ReleaseDate = new DateTime(1997,11,20),
			VoteAverage = 7.4m,
			VoteCount = 1481,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0210945",
			Title = "Remember the Titans",
			Description = "After leading his football team to 15 winning seasons, coach Bill Yoast is demoted and replaced by Herman Boone -  tough, opinionated and as different from the beloved Yoast as he could be. The two men learn to overcome their differences and turn a group of hostile young men into true champions.",
			ReleaseDate = new DateTime(2000,9,29),
			VoteAverage = 7.4m,
			VoteCount = 835,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = "http://movies.disney.com/remember-the-titans"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0783233",
			Title = "Atonement",
			Description = "As a 13-year-old, fledgling writer Briony Tallis irrevocably changes the course of several lives when she accuses her older sister's lover of a crime he did not commit.",
			ReleaseDate = new DateTime(2007,8,29),
			VoteAverage = 7.4m,
			VoteCount = 1075,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0166813",
			Title = "Spirit: Stallion of the Cimarron",
			Description = "As a wild stallion travels across the frontiers of the Old West, he befriends a young human and finds true love with a mare.",
			ReleaseDate = new DateTime(2002,5,24),
			VoteAverage = 7.4m,
			VoteCount = 870,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Western"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0073629",
			Title = "The Rocky Horror Picture Show",
			Description = "Sweethearts Brad and Janet, stuck with a flat tire during a storm, discover the eerie mansion of Dr. Frank-N-Furter, a transvestite scientist. As their innocence is lost, Brad and Janet meet a houseful of wild characters, including a rocking biker and a creepy butler. Through elaborate dances and rock songs, Frank-N-Furter unveils his latest creation: a muscular man named 'Rocky'.",
			ReleaseDate = new DateTime(1975,8,14),
			VoteAverage = 7.4m,
			VoteCount = 703,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.R,
			URL = "http://www.rockyhorror.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0059113",
			Title = "Doctor Zhivago",
			Description = "Doctor Zhivago is the filmed adapation of the Russian novel by Boris Pasternak from director David Lean that was an international success and today deemed a classic. Omar Sharif and Julie Christie play two protagonists who in fact love each other yet because of their current situation cannot find a way be together.",
			ReleaseDate = new DateTime(1965,12,22),
			VoteAverage = 7.4m,
			VoteCount = 252,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0249462",
			Title = "Billy Elliot",
			Description = "Set against the background of the 1984 Miner's Strike, Billy Elliot is an 11 year old boy who stumbles out of the boxing ring and onto the ballet floor. He faces many trials and triumphs as he strives to conquer his family's set ways, inner conflict, and standing on his toes!",
			ReleaseDate = new DateTime(2000,5,18),
			VoteAverage = 7.4m,
			VoteCount = 774,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0079417",
			Title = "Kramer vs. Kramer",
			Description = "Ted Kramer is a career man for whom his work comes before his family. His wife Joanna cannot take this anymore, so she decides to leave him. Ted is now faced with the tasks of housekeeping and taking care of himself and their young son Billy.",
			ReleaseDate = new DateTime(1979,12,18),
			VoteAverage = 7.4m,
			VoteCount = 483,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2562232",
			Title = "Birdman",
			Description = "A fading actor best known for his portrayal of a popular superhero attempts to mount a comeback by appearing in a Broadway play. As opening night approaches, his attempts to become more altruistic, rebuild his career, and reconnect with friends and family prove more difficult than expected.",
			ReleaseDate = new DateTime(2014,8,27),
			VoteAverage = 7.4m,
			VoteCount = 4657,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0117381",
			Title = "Primal Fear",
			Description = "An arrogant, high-powered attorney takes on the case of a poor altar boy found running away from the scene of the grisly murder of the bishop who has taken him in. The case gets a lot more complex when the accused reveals that there may or may not have been a 3rd person in the room. The intensity builds when a surprise twist alters everyone's perception of the crime.",
			ReleaseDate = new DateTime(1996,4,3),
			VoteAverage = 7.4m,
			VoteCount = 644,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0064115",
			Title = "Butch Cassidy and the Sundance Kid",
			Description = "In late 1890s Wyoming, Butch Cassidy is the affable, clever and talkative leader of the outlaw Hole in the Wall Gang. His closest companion is the laconic dead-shot 'Sundance Kid'. As the west rapidly becomes civilized, the law finally catches up to Butch, Sundance and their gang.  Chased doggedly by a special posse, the two decide to make their way to South America in hopes of evading their pursuers once and for all.",
			ReleaseDate = new DateTime(1969,9,23),
			VoteAverage = 7.4m,
			VoteCount = 659,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Western"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0058331",
			Title = "Mary Poppins",
			Description = "The movie combines a diverting story, songs, color and sequences of live action blended with the movements of animated figures. Mary Poppins is a kind of Super-nanny who flies in with her umbrella in response to the request of the Banks children and proceeds to put things right with the aid of her rather extraordinary magical powers before flying off again.",
			ReleaseDate = new DateTime(1964,8,27),
			VoteAverage = 7.4m,
			VoteCount = 1217,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2431286",
			Title = "Philomena",
			Description = "A woman searches for her adult son, who was taken away from her decades ago when she was forced to live in a convent.",
			ReleaseDate = new DateTime(2013,11,1),
			VoteAverage = 7.4m,
			VoteCount = 588,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2488496",
			Title = "Star Wars: The Force Awakens",
			Description = "Thirty years after defeating the Galactic Empire, Han Solo and his allies face a new threat from the evil Kylo Ren and his army of Stormtroopers.",
			ReleaseDate = new DateTime(2015,12,15),
			VoteAverage = 7.5m,
			VoteCount = 7993,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.starwars.com/films/star-wars-episode-vii"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120338",
			Title = "Titanic",
			Description = "84 years later, a 101-year-old woman named Rose DeWitt Bukater tells the story to her granddaughter Lizzy Calvert, Brock Lovett, Lewis Bodine, Bobby Buell and Anatoly Mikailavich on the Keldysh about her life set in April 10th 1912, on a ship called Titanic when young Rose boards the departing ship with the upper-class passengers and her mother, Ruth DeWitt Bukater, and her fiance, Caledon Hockley. Meanwhile, a drifter and artist named Jack Dawson and his best friend Fabrizio De Rossi win third-class tickets to the ship in a game. And she explains the whole story from departure until the death of Titanic on its first and last voyage April 15th, 1912 at 2:20 in the morning.",
			ReleaseDate = new DateTime(1997,11,18),
			VoteAverage = 7.5m,
			VoteCount = 7770,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.titanicmovie.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0241527",
			Title = "Harry Potter and the Philosopher's Stone",
			Description = "Harry Potter has lived under the stairs at his aunt and uncle's house his whole life. But on his 11th birthday, he learns he's a powerful wizard -- with a place waiting for him at the Hogwarts School of Witchcraft and Wizardry. As he learns to harness his newfound powers with the help of the school's kindly headmaster, Harry uncovers the truth about his parents' deaths -- and about the villain who's to blame.",
			ReleaseDate = new DateTime(2001,11,16),
			VoteAverage = 7.5m,
			VoteCount = 7188,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG,
			URL = "http://harrypotter.warnerbros.com/harrypotterandthedeathlyhallows/mainsite/index.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0926084",
			Title = "Harry Potter and the Deathly Hallows: Part 1",
			Description = "Harry, Ron and Hermione walk away from their last year at Hogwarts to find and destroy the remaining Horcruxes, putting an end to Voldemort's bid for immortality. But with Harry's beloved Dumbledore dead and Voldemort's unscrupulous Death Eaters on the loose, the world is more dangerous than ever.",
			ReleaseDate = new DateTime(2010,10,17),
			VoteAverage = 7.5m,
			VoteCount = 5708,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = "http://www.harrypotter.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0330373",
			Title = "Harry Potter and the Goblet of Fire",
			Description = "Harry starts his fourth year at Hogwarts, competes in the treacherous Triwizard Tournament and faces the evil Lord Voldemort. Ron and Hermione help Harry manage the pressure, but Voldemort lurks, awaiting his chance to destroy Harry and all that he stands for.",
			ReleaseDate = new DateTime(2005,11,5),
			VoteAverage = 7.5m,
			VoteCount = 5758,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = "http://harrypotter.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1877832",
			Title = "X-Men: Days of Future Past",
			Description = "The ultimate X-Men ensemble fights a war for the survival of the species across two time periods as they join forces with their younger selves in an epic battle that must change the past to save our future.",
			ReleaseDate = new DateTime(2014,5,15),
			VoteAverage = 7.5m,
			VoteCount = 6155,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.x-menmovies.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0325980",
			Title = "Pirates of the Caribbean: The Curse of the Black Pearl",
			Description = "Jack Sparrow, a freewheeling 17th-century pirate who roams the Caribbean Sea, butts heads with a rival pirate bent on pillaging the village of Port Royal. When the governor's daughter is kidnapped, Sparrow decides to help the girl's love save her. But their seafaring mission is hardly simple.",
			ReleaseDate = new DateTime(2003,7,9),
			VoteAverage = 7.5m,
			VoteCount = 7191,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://disney.go.com/disneyvideos/liveaction/pirates/main_site/main.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0382932",
			Title = "Ratatouille",
			Description = "A rat named Remy dreams of becoming a great French chef despite his family's wishes and the obvious problem of being a rat in a decidedly rodent-phobic profession. When fate places Remy in the sewers of Paris, he finds himself ideally situated beneath a restaurant made famous by his culinary hero, Auguste Gusteau. Despite the apparent dangers of being an unlikely - and certainly unwanted - visitor in the kitchen of a fine French restaurant, Remy's passion for cooking soon sets into motion a hilarious and exciting rat race that turns the culinary world of Paris upside down.",
			ReleaseDate = new DateTime(2007,6,22),
			VoteAverage = 7.5m,
			VoteCount = 4510,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = "http://disney.go.com/disneypictures/ratatouille/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0198781",
			Title = "Monsters, Inc.",
			Description = "James Sullivan and Mike Wazowski are monsters, they earn their living scaring children and are the best in the business... even though they're more afraid of the children than they are of them. When a child accidentally enters their world, James and Mike suddenly find that kids are not to be afraid of and they uncover a conspiracy that could threaten all children across the world.",
			ReleaseDate = new DateTime(2001,11,1),
			VoteAverage = 7.5m,
			VoteCount = 6150,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = "http://movies.disney.com/monsters-inc"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt5013056",
			Title = "Dunkirk",
			Description = "The miraculous evacuation of Allied soldiers from Belgium, Britain, Canada and France, who were cut off and surrounded by the German army from the beaches and harbor of Dunkirk, France, between May 26th and June 4th 1940, during the Battle of France in World War II.",
			ReleaseDate = new DateTime(2017,7,19),
			VoteAverage = 7.5m,
			VoteCount = 2712,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.dunkirkmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0892769",
			Title = "How to Train Your Dragon",
			Description = "As the son of a Viking leader on the cusp of manhood, shy Hiccup Horrendous Haddock III faces a rite of passage: he must kill a dragon to prove his warrior mettle. But after downing a feared dragon, he realizes that he no longer wants to destroy it, and instead befriends the beast - which he names Toothless - much to the chagrin of his warrior father",
			ReleaseDate = new DateTime(2010,3,5),
			VoteAverage = 7.5m,
			VoteCount = 4319,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://www.howtotrainyourdragon.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0073195",
			Title = "Jaws",
			Description = "An insatiable great white shark terrorizes the townspeople of Amity Island, The police chief, an oceanographer and a grizzled shark hunter seek to destroy the bloodthirsty beast.",
			ReleaseDate = new DateTime(1975,6,18),
			VoteAverage = 7.5m,
			VoteCount = 2628,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.PG,
			URL = "http://www.jaws25.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1490017",
			Title = "The Lego Movie",
			Description = "An ordinary Lego mini-figure, mistakenly thought to be the extraordinary MasterBuilder, is recruited to join a quest to stop an evil Lego tyrant from gluing the universe together.",
			ReleaseDate = new DateTime(2014,2,6),
			VoteAverage = 7.5m,
			VoteCount = 3127,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://www.thelegomovie.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0070047",
			Title = "The Exorcist",
			Description = "12-year-old Regan MacNeil begins to adapt an explicit new personality as strange events befall the local area of Georgetown. Her mother becomes torn between science and superstition in a desperate bid to save her daughter, and ultimately turns to her last hope: Father Damien Karras, a troubled priest who is struggling with his own faith.",
			ReleaseDate = new DateTime(1973,12,26),
			VoteAverage = 7.5m,
			VoteCount = 2046,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.R,
			URL = "http://theexorcist.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0162222",
			Title = "Cast Away",
			Description = "Chuck, a top international manager for FedEx, and Kelly, a Ph.D. student, are in love and heading towards marriage. Then Chuck's plane to Malaysia ditches at sea during a terrible storm. He's the only survivor, and he washes up on a tiny island with nothing but some flotsam and jetsam from the aircraft's cargo.",
			ReleaseDate = new DateTime(2000,12,22),
			VoteAverage = 7.5m,
			VoteCount = 3304,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0101414",
			Title = "Beauty and the Beast",
			Description = "Follow the adventures of Belle, a bright young woman who finds herself in the castle of a prince who's been turned into a mysterious beast. With the help of the castle's enchanted staff, Belle soon learns the most important lesson of all -- that true beauty comes from within.",
			ReleaseDate = new DateTime(1991,11,13),
			VoteAverage = 7.5m,
			VoteCount = 3029,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG13,
			URL = "http://disney.go.com/disneyvideos/animatedfilms/beauty/?cmp=dcom_VAN_WDSHE_BEA_van_batb__Extl"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0372784",
			Title = "Batman Begins",
			Description = "Driven by tragedy, billionaire Bruce Wayne dedicates his life to uncovering and defeating the corruption that plagues his home, Gotham City.  Unable to work within the system, he instead creates a new identity, a symbol of fear for the criminal underworld - The Batman.",
			ReleaseDate = new DateTime(2005,6,10),
			VoteAverage = 7.5m,
			VoteCount = 7511,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www2.warnerbros.com/batmanbegins/index.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0102138",
			Title = "JFK",
			Description = "New Orleans District Attorney Jim Garrison discovers there's more to the Kennedy assassination than the official story.",
			ReleaseDate = new DateTime(1991,12,20),
			VoteAverage = 7.5m,
			VoteCount = 513,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0388795",
			Title = "Brokeback Mountain",
			Description = "Brokeback Mountain is an Ang Lee film about two modern day cowboys who meet on a shepherding job in the summer of '63. The two share a raw and powerful summer together that turns into a life long relationship conflicting with the lives they are supposed to live.",
			ReleaseDate = new DateTime(2005,9,2),
			VoteAverage = 7.5m,
			VoteCount = 1531,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.R,
			URL = "http://www.brokebackmountain.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0814314",
			Title = "Seven Pounds",
			Description = "An IRS agent with a fateful secret embarks on an extraordinary journey of redemption by forever changing the lives of seven strangers.",
			ReleaseDate = new DateTime(2008,12,18),
			VoteAverage = 7.5m,
			VoteCount = 2092,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.sonypictures.com/movies/sevenpounds/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0052618",
			Title = "Ben-Hur",
			Description = "Ben-Hur is a 1959 epic film directed by William Wyler, the third film version of Civil War vet Lew Wallace's 1880 novel Ben-Hur: A Tale of the Christ. It premiered at Loew's State Theatre in New York City on November 18, 1959. The movie's reputation as a classic is primarily based on two spectacular action sequences:  the great chariot race and a Roman naval battle, along with lavish production values and strong performances.  The plot of Ben Hur revolves around a Jewish prince who is betrayed and sent into slavery by a Roman friend and how he regains his freedom and comes back for revenge. However, instead he finds redemption in Christ, the theme is ultimately about being saved in the Christian sense.  The film went on to win a record of eleven Academy Awards, including Best Picture and Best Actor (Charlton Heston as Ben Hur). This record-setting Oscars sweep has since been equaled by Titanic in 1998 and The Lord of the Rings: The Return of the King in 2004, but never broken.",
			ReleaseDate = new DateTime(1959,12,26),
			VoteAverage = 7.5m,
			VoteCount = 660,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0095016",
			Title = "Die Hard",
			Description = "NYPD cop, John McClane's plan to reconcile with his estranged wife is thrown for a serious loop when minutes after he arrives at her office, the entire building is overtaken by a group of terrorists. With little help from the LAPD, wisecracking McClane sets out to single-handedly rescue the hostages and bring the bad guys down.",
			ReleaseDate = new DateTime(1988,7,15),
			VoteAverage = 7.5m,
			VoteCount = 4005,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0091763",
			Title = "Platoon",
			Description = "As a young and naive recruit in Vietnam, Chris Taylor faces a moral crisis when confronted with the horrors of war and the duality of man.",
			ReleaseDate = new DateTime(1986,12,18),
			VoteAverage = 7.5m,
			VoteCount = 1236,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0049833",
			Title = "The Ten Commandments",
			Description = "Escaping death, a Hebrew infant is raised in a royal household to become a prince. Upon discovery of his true heritage, Moses embarks on a personal quest to reclaim his destiny as the leader and liberator of the Hebrew people.",
			ReleaseDate = new DateTime(1956,10,5),
			VoteAverage = 7.5m,
			VoteCount = 358,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0075148",
			Title = "Rocky",
			Description = "When world heavyweight boxing champion, Apollo Creed wants to give an unknown fighter a shot at the title as a publicity stunt, his handlers choose palooka Rocky Balboa, an uneducated collector for a Philadelphia loan shark. Rocky teams up with trainer  Mickey Goldmill to make the most of this once in a lifetime break.",
			ReleaseDate = new DateTime(1976,11,21),
			VoteAverage = 7.5m,
			VoteCount = 1843,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0080455",
			Title = "The Blues Brothers",
			Description = "Jake Blues is just out of jail, and teams up with his brother, Elwood on a 'mission from God' to raise funds for the orphanage in which they grew up. The only thing they can do is do what they do best - play music - so they get their old band together and they're on their way, while getting in a bit of trouble here and there.",
			ReleaseDate = new DateTime(1980,6,17),
			VoteAverage = 7.5m,
			VoteCount = 1092,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0119174",
			Title = "The Game",
			Description = "In honor of his birthday, San Francisco banker Nicholas Van Orton, a financial genius and a coldhearted loner, receives an unusual present from his younger brother, Conrad -- a gift certificate to play a unique kind of game. In nearly a nanosecond, Nicholas finds himself consumed by a dangerous set of ever-changing rules, unable to distinguish where the charade ends and reality begins.",
			ReleaseDate = new DateTime(1997,9,12),
			VoteAverage = 7.5m,
			VoteCount = 1556,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0393597",
			Title = "Earth",
			Description = "From the acclaimed team that brought you BBC's visual feast 'Planet Earth,' this feature length film incorporates some of the same footage from the series with all new scenes following three remarkable, yet sadly endangered, families of animal across the globe.",
			ReleaseDate = new DateTime(2007,4,22),
			VoteAverage = 7.5m,
			VoteCount = 136,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Documentary"),
			Rating = Rating.G,
			URL = "http://www.loveearth.com/de/earthfilm"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0449059",
			Title = "Little Miss Sunshine",
			Description = "A family loaded with quirky, colorful characters piles into an old van and road trips to California for little Olive to compete in a beauty pageant.",
			ReleaseDate = new DateTime(2006,7,26),
			VoteAverage = 7.5m,
			VoteCount = 1728,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.R,
			URL = "http://www.foxsearchlight.com/littlemisssunshine/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1345836",
			Title = "The Dark Knight Rises",
			Description = "Following the death of District Attorney Harvey Dent, Batman assumes responsibility for Dent's crimes to protect the late attorney's reputation and is subsequently hunted by the Gotham City Police Department. Eight years later, Batman encounters the mysterious Selina Kyle and the villainous Bane, a new terrorist leader who overwhelms Gotham's finest. The Dark Knight resurfaces to protect a city that has branded him an enemy.",
			ReleaseDate = new DateTime(2012,7,16),
			VoteAverage = 7.6m,
			VoteCount = 9263,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.thedarkknightrises.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0435761",
			Title = "Toy Story 3",
			Description = "Woody, Buzz, and the rest of Andy's toys haven't been played with in years. With Andy about to go to college, the gang find themselves accidentally left at a nefarious day care center. The toys must band together to escape and return home to Andy.",
			ReleaseDate = new DateTime(2010,6,16),
			VoteAverage = 7.6m,
			VoteCount = 4710,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = "http://disney.go.com/toystory/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1170358",
			Title = "The Hobbit: The Desolation of Smaug",
			Description = "The Dwarves, Bilbo and Gandalf have successfully escaped the Misty Mountains, and Bilbo has gained the One Ring. They all continue their journey to get their gold back from the Dragon, Smaug.",
			ReleaseDate = new DateTime(2013,12,11),
			VoteAverage = 7.6m,
			VoteCount = 4633,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.thehobbit.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0266543",
			Title = "Finding Nemo",
			Description = "Nemo, an adventurous young clownfish, is unexpectedly taken from his Great Barrier Reef home to a dentist's office aquarium. It's up to his worrisome father Marlin and a friendly but forgetful fish Dory to bring Nemo home -- meeting vegetarian sharks, surfer dude turtles, hypnotic jellyfish, hungry seagulls, and more along the way.",
			ReleaseDate = new DateTime(2003,5,30),
			VoteAverage = 7.6m,
			VoteCount = 6292,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = "http://movies.disney.com/finding-nemo"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0107290",
			Title = "Jurassic Park",
			Description = "A wealthy entrepreneur secretly creates a theme park featuring living dinosaurs drawn from prehistoric DNA. Before opening day, he invites a team of experts and his two eager grandchildren to experience the park and help calm anxious investors. However, the park is anything but amusing as the security systems go off-line and the dinosaurs escape.",
			ReleaseDate = new DateTime(1993,6,11),
			VoteAverage = 7.6m,
			VoteCount = 4956,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG13,
			URL = "http://www.jurassicpark.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3896198",
			Title = "Guardians of the Galaxy Vol. 2",
			Description = "The Guardians must fight to keep their newfound family together as they unravel the mysteries of Peter Quill's true parentage.",
			ReleaseDate = new DateTime(2017,4,19),
			VoteAverage = 7.6m,
			VoteCount = 4858,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://marvel.com/movies/movie/221/guardians_of_the_galaxy_vol_2"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1843866",
			Title = "Captain America: The Winter Soldier",
			Description = "After the cataclysmic events in New York with The Avengers, Steve Rogers, aka Captain America is living quietly in Washington, D.C. and trying to adjust to the modern world. But when a S.H.I.E.L.D. colleague comes under attack, Steve becomes embroiled in a web of intrigue that threatens to put the world at risk. Joining forces with the Black Widow, Captain America struggles to expose the ever-widening conspiracy while fighting off professional assassins sent to silence him at every turn. When the full scope of the villainous plot is revealed, Captain America and the Black Widow enlist the help of a new ally, the Falcon. However, they soon find themselves up against an unexpected and formidable enemy - the Winter Soldier.",
			ReleaseDate = new DateTime(2014,3,20),
			VoteAverage = 7.6m,
			VoteCount = 5881,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.captainamericathewintersoldiermovie.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3659388",
			Title = "The Martian",
			Description = "During a manned mission to Mars, Astronaut Mark Watney is presumed dead after a fierce storm and left behind by his crew. But Watney has survived and finds himself stranded and alone on the hostile planet. With only meager supplies, he must draw upon his ingenuity, wit and spirit to subsist and find a way to signal to Earth that he is alive.",
			ReleaseDate = new DateTime(2015,9,30),
			VoteAverage = 7.6m,
			VoteCount = 7442,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.foxmovies.com/movies/the-martian"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3315342",
			Title = "Logan",
			Description = "In the near future, a weary Logan cares for an ailing Professor X in a hideout on the Mexican border. But Logan's attempts to hide from the world and his legacy are upended when a young mutant arrives, pursued by dark forces.",
			ReleaseDate = new DateTime(2017,2,28),
			VoteAverage = 7.6m,
			VoteCount = 6310,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = "http://www.foxmovies.com/movies/logan"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1646971",
			Title = "How to Train Your Dragon 2",
			Description = "The thrilling second chapter of the epic How To Train Your Dragon trilogy brings back the fantastical world of Hiccup and Toothless five years later. While Astrid, Snotlout and the rest of the gang are challenging each other to dragon races (the island's new favorite contact sport), the now inseparable pair journey through the skies, charting unmapped territories and exploring new worlds. When one of their adventures leads to the discovery of a secret ice cave that is home to hundreds of new wild dragons and the mysterious Dragon Rider, the two friends find themselves at the center of a battle to protect the peace.",
			ReleaseDate = new DateTime(2014,6,12),
			VoteAverage = 7.6m,
			VoteCount = 3163,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://www.howtotrainyourdragon.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0097576",
			Title = "Indiana Jones and the Last Crusade",
			Description = "When Dr. Henry Jones Sr. suddenly goes missing while pursuing the Holy Grail, eminent archaeologist Indiana must team up with Marcus Brody, Sallah and Elsa Schneider to follow in his father's footsteps and stop the Nazis from recovering the power of eternal life.",
			ReleaseDate = new DateTime(1989,5,24),
			VoteAverage = 7.6m,
			VoteCount = 3221,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.indianajones.com/crusade"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0099348",
			Title = "Dances with Wolves",
			Description = "Wounded Civil War soldier, John Dunbar tries to commit suicide and becomes a hero instead. As a reward, he's assigned to his dream post, a remote junction on the Western frontier, and soon makes unlikely friends with the local Sioux tribe.",
			ReleaseDate = new DateTime(1990,11,9),
			VoteAverage = 7.6m,
			VoteCount = 1084,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Western"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2802144",
			Title = "Kingsman: The Secret Service",
			Description = "The story of a super-secret spy organization that recruits an unrefined but promising street kid into the agency's ultra-competitive training program just as a global threat emerges from a twisted tech genius.",
			ReleaseDate = new DateTime(2015,1,29),
			VoteAverage = 7.6m,
			VoteCount = 6069,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://www.kingsmanmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1504320",
			Title = "The King's Speech",
			Description = "The King's Speech tells the story of the man who became King George VI, the father of Queen Elizabeth II. After his brother abdicates, George ('Bertie') reluctantly assumes the throne. Plagued by a dreaded stutter and considered unfit to be king, Bertie engages the help of an unorthodox speech therapist named Lionel Logue. Through a set of unexpected techniques, and as a result of an unlikely friendship, Bertie is able to find his voice and boldly lead the country into war.",
			ReleaseDate = new DateTime(2010,9,6),
			VoteAverage = 7.6m,
			VoteCount = 2817,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.kingsspeech.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0095953",
			Title = "Rain Man",
			Description = "Selfish yuppie Charlie Babbitt's father left a fortune to his savant brother Raymond and a pittance to Charlie; they travel cross-country.",
			ReleaseDate = new DateTime(1988,12,11),
			VoteAverage = 7.6m,
			VoteCount = 1762,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1631867",
			Title = "Edge of Tomorrow",
			Description = "Major Bill Cage is an officer who has never seen a day of combat when he is unceremoniously demoted and dropped into combat. Cage is killed within minutes, managing to take an alpha alien down with him. He awakens back at the beginning of the same day and is forced to fight and die again... and again - as physical contact with the alien has thrown him into a time loop.",
			ReleaseDate = new DateTime(2014,5,27),
			VoteAverage = 7.6m,
			VoteCount = 4979,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://www.edgeoftomorrowmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2582846",
			Title = "The Fault in Our Stars",
			Description = "Despite the tumor-shrinking medical miracle that has bought her a few years, Hazel has never been anything but terminal, her final chapter inscribed upon diagnosis. But when a patient named Augustus Waters suddenly appears at Cancer Kid Support Group, Hazel's story is about to be completely rewritten.",
			ReleaseDate = new DateTime(2014,5,16),
			VoteAverage = 7.6m,
			VoteCount = 3868,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120762",
			Title = "Mulan",
			Description = "A tomboyish girl disguises herself as a young man so she can fight with the Imperial Chinese Army against the invading Huns. With help from wise-cracking dragon Mushu, Mulan just might save her country -- and win the heart of handsome Captain Li Shang.",
			ReleaseDate = new DateTime(1998,6,18),
			VoteAverage = 7.6m,
			VoteCount = 2089,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2674426",
			Title = "Me Before You",
			Description = "A small town girl is caught between dead-end jobs. A high-profile, successful man becomes wheelchair bound following an accident. The man decides his life is not worth living until the girl is hired for six months to be his new caretaker. Worlds apart and trapped together by circumstance, the two get off to a rocky start. But the girl becomes determined to prove to the man that life is worth living and as they embark on a series of adventures together, each finds their world changing in ways neither of them could begin to imagine.",
			ReleaseDate = new DateTime(2016,6,2),
			VoteAverage = 7.6m,
			VoteCount = 2674,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG13,
			URL = "http://www.mebeforeyoumovie.net"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0107818",
			Title = "Philadelphia",
			Description = "No one would take his case until one man was willing to take on the system. Two competing lawyers join forces to sue a prestigious law firm for AIDS discrimination. As their unlikely friendship develops their courage overcomes the prejudice and corruption of their powerful adversaries.",
			ReleaseDate = new DateTime(1993,12,22),
			VoteAverage = 7.6m,
			VoteCount = 1019,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0327056",
			Title = "Mystic River",
			Description = "A story about friendship and loyalty, guilt and vengeance, and the fateful affect the past has on the present.",
			ReleaseDate = new DateTime(2003,10,7),
			VoteAverage = 7.6m,
			VoteCount = 1473,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3460252",
			Title = "The Hateful Eight",
			Description = "Bounty hunters seek shelter from a raging blizzard and get caught up in a plot of betrayal and deception.",
			ReleaseDate = new DateTime(2015,12,25),
			VoteAverage = 7.6m,
			VoteCount = 4405,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://thehatefuleight.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0319061",
			Title = "Big Fish",
			Description = "Throughout his life Edward Bloom has always been a man of big appetites, enormous passions and tall tales. In his later years, he remains a huge mystery to his son, William. Now, to get to know the real man, Will begins piecing together a true picture of his father from flashbacks of his amazing adventures.",
			ReleaseDate = new DateTime(2003,12,25),
			VoteAverage = 7.6m,
			VoteCount = 2064,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0101921",
			Title = "Fried Green Tomatoes",
			Description = "Amidst her own personality crisis, southern housewife Evelyn Couch meets Ninny, an outgoing old woman who tells her the story of Idgie Threadgoode and Ruth Jamison, two young women who experienced hardships and love in Whistle Stop, Alabama in the 1920s.",
			ReleaseDate = new DateTime(1991,12,27),
			VoteAverage = 7.6m,
			VoteCount = 298,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0061722",
			Title = "The Graduate",
			Description = "A recent college graduate finds himself in a love triangle with an older woman and her daughter.",
			ReleaseDate = new DateTime(1967,12,21),
			VoteAverage = 7.6m,
			VoteCount = 855,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2948356",
			Title = "Zootopia",
			Description = "Determined to prove herself, Officer Judy Hopps, the first bunny on Zootopia's police force, jumps at the chance to crack her first case - even if it means partnering with scam-artist fox Nick Wilde to solve the mystery.",
			ReleaseDate = new DateTime(2016,2,11),
			VoteAverage = 7.7m,
			VoteCount = 4961,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://movies.disney.com/zootopia"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0304141",
			Title = "Harry Potter and the Prisoner of Azkaban",
			Description = "Harry, Ron and Hermione return to Hogwarts for another magic-filled year. Harry comes face to face with danger yet again, this time in the form of escaped convict, Sirius Black, and turns to sympathetic Professor Lupin for help.",
			ReleaseDate = new DateTime(2004,5,31),
			VoteAverage = 7.7m,
			VoteCount = 6037,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0167404",
			Title = "The Sixth Sense",
			Description = "A psychological thriller about an eight year old boy named Cole Sear who believes he can see into the world of the dead. A child psychologist named Malcolm Crowe comes to Cole to help him deal with his problem, learning that he really can see ghosts of dead people.",
			ReleaseDate = new DateTime(1999,8,6),
			VoteAverage = 7.7m,
			VoteCount = 3223,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0103064",
			Title = "Terminator 2: Judgment Day",
			Description = "Nearly 10 years have passed since Sarah Connor was targeted for termination by a cyborg from the future. Now her son, John, the future leader of the resistance, is the target for a newer, more deadly terminator. Once again, the resistance has managed to send a protector back to attempt to save John and his mother Sarah.",
			ReleaseDate = new DateTime(1991,7,1),
			VoteAverage = 7.7m,
			VoteCount = 4274,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0031381",
			Title = "Gone with the Wind",
			Description = "An American classic in which a manipulative woman and a roguish man carry on a turbulent love affair in the American south during the Civil War and Reconstruction.",
			ReleaseDate = new DateTime(1939,12,15),
			VoteAverage = 7.7m,
			VoteCount = 995,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.Unrated,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0082971",
			Title = "Raiders of the Lost Ark",
			Description = "When Dr. Indiana Jones, the tweed-suited professor who just happens to be a celebrated archaeologist, is hired by the government to locate the legendary Ark of the Covenant, he finds himself up against the entire Nazi regime.",
			ReleaseDate = new DateTime(1981,6,12),
			VoteAverage = 7.7m,
			VoteCount = 3949,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = "http://www.indianajones.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0114709",
			Title = "Toy Story",
			Description = "Led by Woody, Andy's toys live happily in his room until Andy's birthday brings Buzz Lightyear onto the scene. Afraid of losing his place in Andy's heart, Woody plots against Buzz. But when circumstances separate Buzz and Woody from their owner, the duo eventually learns to put aside their differences.",
			ReleaseDate = new DateTime(1995,10,30),
			VoteAverage = 7.7m,
			VoteCount = 5415,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = "http://toystory.disney.com/toy-story"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0264464",
			Title = "Catch Me If You Can",
			Description = "A true story about Frank Abagnale Jr. who, before his 19th birthday, successfully conned millions of dollars worth of checks as a Pan Am pilot, doctor, and legal prosecutor. An FBI agent makes it his mission to put him behind bars. But Frank not only eludes capture, he revels in the pursuit.",
			ReleaseDate = new DateTime(2002,12,25),
			VoteAverage = 7.7m,
			VoteCount = 3917,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "https://www.facebook.com/CatchMeIfYouCanMovie"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0268978",
			Title = "A Beautiful Mind",
			Description = "At Princeton University, John Nash struggles to make a worthwhile contribution to serve as his legacy to the world of mathematics. He finally makes a revolutionary breakthrough that will eventually earn him the Nobel Prize. After graduate school he turns to teaching, becoming romantically involved with his student Alicia. Meanwhile the government asks his help with breaking Soviet codes, which soon gets him involved in a terrifying conspiracy plot. Nash grows more and more paranoid until a discovery that turns his entire world upside down. Now it is only with Alicia's help that he will be able to recover his mental strength and regain his status as the great mathematician we know him as today..",
			ReleaseDate = new DateTime(2001,12,11),
			VoteAverage = 7.7m,
			VoteCount = 3087,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.abeautifulmind.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0454921",
			Title = "The Pursuit of Happyness",
			Description = "The true story of Christopher Gardner, who invests heavily in a device known as a 'Bone Density Scanner', only to find himself struggle to sell the product as it's just marginally better than the current technology, and much more expensive. His wife leaves him,  he loses his house, bank account and credit cards and, now forced to live out in the streets with his young son,  he's desperate to find a steady job. He takes on a job as a stockbroker but, before he can receive pay, he needs to go through 6 months of training, and must sell his devices.",
			ReleaseDate = new DateTime(2006,12,14),
			VoteAverage = 7.7m,
			VoteCount = 2607,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.sonypictures.com/homevideo/thepursuitofhappyness/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0405159",
			Title = "Million Dollar Baby",
			Description = "Despondent over a painful estrangement from his daughter, trainer Frankie Dunn isn't prepared for boxer Maggie Fitzgerald to enter his life. But Maggie's determined to go pro and to convince Dunn and his cohort to help her.",
			ReleaseDate = new DateTime(2004,12,15),
			VoteAverage = 7.7m,
			VoteCount = 2519,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.milliondollarbaby-derfilm.de/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0112573",
			Title = "Braveheart",
			Description = "Enraged at the slaughter of Murron, his new bride and childhood love, Scottish warrior William Wallace slays a platoon of the local English lord's soldiers. This leads the village to revolt and, eventually, the entire country to rise up against English rule.",
			ReleaseDate = new DateTime(1995,5,24),
			VoteAverage = 7.7m,
			VoteCount = 3404,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1398426",
			Title = "Straight Outta Compton",
			Description = "In 1987, five young men, using brutally honest rhymes and hardcore beats, put their frustration and anger about life in the most dangerous place in America into the most powerful weapon they had: their music.  Taking us back to where it all began, Straight Outta Compton tells the true story of how these cultural rebels - armed only with their lyrics, swagger, bravado and raw talents - stood up to the authorities that meant to keep them down and formed the world's most dangerous group, N.W.A.  And as they spoke the truth that no one had before and exposed life in the hood, their voice ignited a social revolution that is still reverberating today.",
			ReleaseDate = new DateTime(2015,8,13),
			VoteAverage = 7.7m,
			VoteCount = 1381,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.straightouttacompton.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0113277",
			Title = "Heat",
			Description = "Obsessive master thief, Neil McCauley leads a top-notch crew on various insane heists throughout Los Angeles while a mentally unstable detective, Vincent Hanna pursues him without rest. Each man recognizes and respects the ability and the dedication of the other even though they are aware their cat-and-mouse game may end in violence.",
			ReleaseDate = new DateTime(1995,12,15),
			VoteAverage = 7.7m,
			VoteCount = 1886,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0090605",
			Title = "Aliens",
			Description = "When Ripley's lifepod is found by a salvage crew over 50 years later, she finds that terra-formers are on the very planet they found the alien species. When the company sends a family of colonists out to investigate her story, all contact is lost with the planet and colonists. They enlist Ripley and the colonial marines to return and search for answers.",
			ReleaseDate = new DateTime(1986,7,18),
			VoteAverage = 7.7m,
			VoteCount = 3282,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0266697",
			Title = "Kill Bill: Vol. 1",
			Description = "An assassin is shot at the altar by her ruthless employer, Bill and other members of their assassination circle but 'The Bride' lives to plot her vengeance. Setting out for some payback, she makes a death list and hunts down those who wronged her, saving Bill for last.",
			ReleaseDate = new DateTime(2003,10,10),
			VoteAverage = 7.7m,
			VoteCount = 5091,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = "http://www.miramax.com/movie/kill-bill-volume-1/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0477348",
			Title = "No Country for Old Men",
			Description = "Llewelyn Moss stumbles upon dead bodies, $2 million and a hoard of heroin in a Texas desert, but methodical killer Anton Chigurh comes looking for it, with local sheriff Ed Tom Bell hot on his trail. The roles of prey and predator blur as the violent pursuit of money and justice collide.",
			ReleaseDate = new DateTime(2007,11,8),
			VoteAverage = 7.7m,
			VoteCount = 3083,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0105695",
			Title = "Unforgiven",
			Description = "William Munny is a retired, once-ruthless killer turned gentle widower and hog farmer. To help support his two motherless children, he accepts one last bounty-hunter mission to find the men who brutalized a prostitute. Joined by his former partner and a cocky greenhorn, he takes on a corrupt sheriff.",
			ReleaseDate = new DateTime(1992,8,7),
			VoteAverage = 7.7m,
			VoteCount = 1133,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Western"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0378194",
			Title = "Kill Bill: Vol. 2",
			Description = "The Bride unwaveringly continues on her roaring rampage of revenge against the band of assassins who had tried to kill her and her unborn child. She visits each of her former associates one-by-one, checking off the victims on her Death List Five until there's nothing left to do but kill Bill.",
			ReleaseDate = new DateTime(2004,4,16),
			VoteAverage = 7.7m,
			VoteCount = 4061,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0088939",
			Title = "The Color Purple",
			Description = "An epic tale spanning forty years in the life of Celie (Whoopi Goldberg), an African-American woman living in the South who survives incredible abuse and bigotry.  After Celie's abusive father marries her off to the equally debasing 'Mister' Albert Johnson (Danny Glover), things go from bad to worse, leaving Celie to find companionship anywhere she can.  She perseveres, holding on to her dream of one day being reunited with her sister in Africa.  Based on the novel by Alice Walker.",
			ReleaseDate = new DateTime(1985,12,18),
			VoteAverage = 7.7m,
			VoteCount = 345,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0434409",
			Title = "V for Vendetta",
			Description = "In a world in which Great Britain has become a fascist state, a masked vigilante known only as 'V' conducts guerrilla warfare against the oppressive British government. When 'V' rescues a young woman from the secret police, he finds in her an ally with whom he can continue his fight to free the people of Britain.",
			ReleaseDate = new DateTime(2006,3,15),
			VoteAverage = 7.7m,
			VoteCount = 4562,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://vforvendetta.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0119488",
			Title = "L.A. Confidential",
			Description = "Three detectives in the corrupt and brutal L.A. police force of the 1950s use differing methods to uncover a conspiracy behind the shotgun slayings of the patrons at an all-night diner.",
			ReleaseDate = new DateTime(1997,9,19),
			VoteAverage = 7.7m,
			VoteCount = 1340,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0332280",
			Title = "The Notebook",
			Description = "An epic love story centered around an older man who reads aloud to a woman with Alzheimer's. From a faded notebook, the old man's words bring to life the story about a couple who is separated by World War II, and is then passionately reunited, seven years later, after they have taken different paths.",
			ReleaseDate = new DateTime(2004,6,25),
			VoteAverage = 7.7m,
			VoteCount = 3163,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG13,
			URL = "http://www.newline.com/properties/notebookthe.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1049413",
			Title = "Up",
			Description = "Carl Fredricksen spent his entire life dreaming of exploring the globe and experiencing life to its fullest. But at age 78, life seems to have passed him by, until a twist of fate (and a persistent 8-year old Wilderness Explorer named Russell) gives him a new lease on life.",
			ReleaseDate = new DateTime(2009,5,13),
			VoteAverage = 7.8m,
			VoteCount = 7048,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://disney.go.com/disneypictures/up/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2245084",
			Title = "Big Hero 6",
			Description = "The special bond that develops between plus-sized inflatable robot Baymax, and prodigy Hiro Hamada, who team up with a group of friends to form a band of high-tech heroes.",
			ReleaseDate = new DateTime(2014,10,24),
			VoteAverage = 7.8m,
			VoteCount = 6289,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://movies.disney.com/big-hero-6"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1853728",
			Title = "Django Unchained",
			Description = "With the help of a German bounty hunter, a freed slave sets out to rescue his wife from a brutal Mississippi plantation owner.",
			ReleaseDate = new DateTime(2012,12,25),
			VoteAverage = 7.8m,
			VoteCount = 10297,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://unchainedmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1130884",
			Title = "Shutter Island",
			Description = "World War II soldier-turned-U.S. Marshal Teddy Daniels investigates the disappearance of a patient from a hospital for the criminally insane, but his efforts are compromised by his troubling visions and also by a mysterious doctor.",
			ReleaseDate = new DateTime(2010,2,18),
			VoteAverage = 7.8m,
			VoteCount = 6559,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.shutterisland.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1205489",
			Title = "Gran Torino",
			Description = "Walt Kowalski is a widower who holds onto his prejudices despite the changes in his Michigan neighborhood and the world around him. Kowalski is a grumpy, tough-minded, unhappy old man who can't get along with either his kids or his neighbors. He is a Korean War veteran whose prize possession is a 1972 Gran Torino he keeps in mint condition. When his neighbor Thao, a young Hmong teenager under pressure from his gang member cousin, tries to steal his Gran Torino, Kowalski sets out to reform the youth. Drawn against his will into the life of Thao's family, Kowalski is soon taking steps to protect them from the gangs that infest their neighborhood.",
			ReleaseDate = new DateTime(2008,12,9),
			VoteAverage = 7.8m,
			VoteCount = 3181,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.thegrantorino.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120382",
			Title = "The Truman Show",
			Description = "Truman Burbank is the star of 'The Truman Show', a 24-hour-a-day 'reality' TV show that broadcasts every aspect of his life -- live and in color -- without his knowledge. His entire life has been an unending soap opera for consumption by the rest of the world. And everyone he knows -- including his wife and his best friend -- is really an actor, paid to be part of his life.",
			ReleaseDate = new DateTime(1998,6,4),
			VoteAverage = 7.8m,
			VoteCount = 4702,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt4846340",
			Title = "Hidden Figures",
			Description = "The untold story of Katherine G. Johnson, Dorothy Vaughan and Mary Jackson -  brilliant African-American women working at NASA and serving as the brains behind one of the greatest operations in history - the launch of astronaut John Glenn into orbit. The visionary trio crossed all gender and race lines to inspire generations to dream big.",
			ReleaseDate = new DateTime(2016,12,10),
			VoteAverage = 7.8m,
			VoteCount = 2178,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = "http://www.hiddenfigures.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2119532",
			Title = "Hacksaw Ridge",
			Description = "WWII American Army Medic Desmond T. Doss, who served during the Battle of Okinawa, refuses to kill people and becomes the first Conscientious Objector in American history to receive the Congressional Medal of Honor.",
			ReleaseDate = new DateTime(2016,10,7),
			VoteAverage = 7.8m,
			VoteCount = 3294,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.hacksawridge.movie/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2980516",
			Title = "The Theory of Everything",
			Description = "The Theory of Everything is the extraordinary story of one of the world's greatest living minds, the renowned astrophysicist Stephen Hawking, who falls deeply in love with fellow Cambridge student Jane Wilde.",
			ReleaseDate = new DateTime(2014,11,26),
			VoteAverage = 7.8m,
			VoteCount = 3403,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://www.focusfeatures.com/the_theory_of_everything"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0414387",
			Title = "Pride & Prejudice",
			Description = "Pride & Prejudice is a humorous story of love and life among English gentility during the Georgian era. Mr. Bennet is an English gentleman living in Hertfordshire with his overbearing wife and five daughters. If Mr. Bennet dies their house will be inherited by a distant cousin whom they have never met, so the family's future happiness and security is dependent on the daughters making good marriages.",
			ReleaseDate = new DateTime(2005,9,16),
			VoteAverage = 7.8m,
			VoteCount = 1406,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Romance"),
			Rating = Rating.PG,
			URL = "http://www.prideandprejudicemovie.net/splash.html"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0112641",
			Title = "Casino",
			Description = "The life of the gambling paradise Las Vegas and its dark mafia underbelly.",
			ReleaseDate = new DateTime(1995,11,22),
			VoteAverage = 7.8m,
			VoteCount = 1343,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1201607",
			Title = "Harry Potter and the Deathly Hallows: Part 2",
			Description = "Harry, Ron and Hermione continue their quest to vanquish the evil Voldemort once and for all. Just as things begin to look hopeless for the young wizards, Harry discovers a trio of magical objects that endow him with powers to rival Voldemort's formidable skills.",
			ReleaseDate = new DateTime(2011,7,7),
			VoteAverage = 7.9m,
			VoteCount = 6141,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Fantasy"),
			Rating = Rating.PG13,
			URL = "http://www.harrypotter.com"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2096673",
			Title = "Inside Out",
			Description = "Growing up can be a bumpy road, and it's no exception for Riley, who is uprooted from her Midwest life when her father starts a new job in San Francisco. Like all of us, Riley is guided by her emotions - Joy, Fear, Anger, Disgust and Sadness. The emotions live in Headquarters, the control center inside Riley's mind, where they help advise her through everyday life. As Riley and her emotions struggle to adjust to a new life in San Francisco, turmoil ensues in Headquarters. Although Joy, Riley's main and most important emotion, tries to keep things positive, the emotions conflict on how best to navigate a new city, house and school.",
			ReleaseDate = new DateTime(2015,6,9),
			VoteAverage = 7.9m,
			VoteCount = 6737,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.PG,
			URL = "http://movies.disney.com/inside-out"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2015381",
			Title = "Guardians of the Galaxy",
			Description = "Light years from Earth, 26 years after being abducted, Peter Quill finds himself the prime target of a manhunt after discovering an orb wanted by Ronan the Accuser.",
			ReleaseDate = new DateTime(2014,7,30),
			VoteAverage = 7.9m,
			VoteCount = 10014,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://marvel.com/guardians"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0086190",
			Title = "Return of the Jedi",
			Description = "As Rebel leaders map their strategy for an all-out attack on the Emperor's newer, bigger Death Star. Han Solo remains frozen in the cavernous desert fortress of Jabba the Hutt, the most loathsome outlaw in the universe, who is also keeping Princess Leia as a slave girl. Now a master of the Force, Luke Skywalker rescues his friends, but he cannot become a true Jedi Knight until he wages his own crucial battle against Darth Vader, who has sworn to win Luke over to the dark side of the Force.",
			ReleaseDate = new DateTime(1983,5,23),
			VoteAverage = 7.9m,
			VoteCount = 4763,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = "http://www.starwars.com/films/star-wars-episode-vi-return-of-the-jedi"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120815",
			Title = "Saving Private Ryan",
			Description = "As U.S. troops storm the beaches of Normandy, three brothers lie dead on the battlefield, with a fourth trapped behind enemy lines. Ranger captain John Miller and seven men are tasked with penetrating German-held territory and bringing the boy home.",
			ReleaseDate = new DateTime(1998,7,24),
			VoteAverage = 7.9m,
			VoteCount = 5148,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0133093",
			Title = "The Matrix",
			Description = "Set in the 22nd century, The Matrix tells the story of a computer hacker who joins a group of underground insurgents fighting the vast and powerful computers who now rule the earth.",
			ReleaseDate = new DateTime(1999,3,30),
			VoteAverage = 7.9m,
			VoteCount = 9079,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.R,
			URL = "http://www.warnerbros.com/matrix"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0172495",
			Title = "Gladiator",
			Description = "In the year 180, the death of emperor Marcus Aurelius throws the Roman Empire into chaos. Maximus is one of the Roman army's most capable and trusted generals and a key advisor to the emperor. As Marcus' devious son Commodus ascends to the throne, Maximus is set to be executed. He escapes, but is captured by slave traders. Renamed Spaniard and forced to become a gladiator, Maximus must battle to the death with other men for the amusement of paying audiences. His battle skills serve him well, and he becomes one of the most famous and admired men to fight in the Colosseum. Determined to avenge himself against the man who took away his freedom and laid waste to his family, Maximus believes that he can use his fame and skill in the ring to avenge the loss of his family and former glory. As the gladiator begins to challenge his rule, Commodus decides to put his own fighting mettle to the test by squaring off with Maximus in a battle to the death.",
			ReleaseDate = new DateTime(2000,5,1),
			VoteAverage = 7.9m,
			VoteCount = 5566,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3783958",
			Title = "La La Land",
			Description = "Mia, an aspiring actress, serves lattes to movie stars in between auditions and Sebastian, a jazz musician, scrapes by playing cocktail party gigs in dingy bars, but as success mounts they are faced with decisions that begin to fray the fragile fabric of their love affair, and the dreams they worked so hard to maintain in each other threaten to rip them apart.",
			ReleaseDate = new DateTime(2016,11,29),
			VoteAverage = 7.9m,
			VoteCount = 4745,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Musical"),
			Rating = Rating.PG13,
			URL = "http://www.lalaland.movie/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0993846",
			Title = "The Wolf of Wall Street",
			Description = "A New York stockbroker refuses to cooperate in a large securities fraud case involving corruption on Wall Street, corporate banking world and mob infiltration. Based on Jordan Belfort's autobiography.",
			ReleaseDate = new DateTime(2013,12,25),
			VoteAverage = 7.9m,
			VoteCount = 6768,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://www.thewolfofwallstreet.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2267998",
			Title = "Gone Girl",
			Description = "With his wife's disappearance having become the focus of an intense media circus, a man sees the spotlight turned on him when it's suspected that he may not be innocent.",
			ReleaseDate = new DateTime(2014,10,1),
			VoteAverage = 7.9m,
			VoteCount = 6023,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery"),
			Rating = Rating.R,
			URL = "http://www.gonegirlmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0169547",
			Title = "American Beauty",
			Description = "Lester Burnham, a depressed suburban father in a mid-life crisis, decides to turn his hectic life around after developing an infatuation with his daughter's attractive friend.",
			ReleaseDate = new DateTime(1999,9,15),
			VoteAverage = 7.9m,
			VoteCount = 3438,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.dreamworks.com/ab/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0361748",
			Title = "Inglourious Basterds",
			Description = "In Nazi-occupied France during World War II, a group of Jewish-American soldiers known as 'The Basterds' are chosen specifically to spread fear throughout the Third Reich by scalping and brutally killing Nazis. The Basterds, lead by Lt. Aldo Raine soon cross paths with a French-Jewish teenage girl who runs a movie theater in Paris which is targeted by the soldiers.",
			ReleaseDate = new DateTime(2009,8,18),
			VoteAverage = 7.9m,
			VoteCount = 6598,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.inglouriousbasterds-movie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0407887",
			Title = "The Departed",
			Description = "To take down South Boston's Irish Mafia, the police send in one of their own to infiltrate the underworld, not realizing the syndicate has done likewise. While an undercover cop curries favor with the mob kingpin, a career criminal rises through the police ranks. But both sides soon discover there's a mole among them.",
			ReleaseDate = new DateTime(2006,10,5),
			VoteAverage = 7.9m,
			VoteCount = 4455,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = "http://thedeparted.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0119217",
			Title = "Good Will Hunting",
			Description = "Will Hunting has a genius-level IQ but chooses to work as a janitor at MIT. When he solves a difficult graduate-level math problem, his talents are discovered by Professor Gerald Lambeau, who decides to help the misguided youth reach his potential. When Will is arrested for attacking a police officer, Professor Lambeau makes a deal to get leniency for him if he will get treatment from therapist Sean Maguire.",
			ReleaseDate = new DateTime(1997,12,5),
			VoteAverage = 7.9m,
			VoteCount = 2880,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.miramax.com/movie/good-will-hunting"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2024544",
			Title = "12 Years a Slave",
			Description = "In the pre-Civil War United States, Solomon Northup, a free black man from upstate New York, is abducted and sold into slavery. Facing cruelty as well as unexpected kindnesses Solomon struggles not only to stay alive, but to retain his dignity. In the twelfth year of his unforgettable odyssey, Solomon's chance meeting with a Canadian abolitionist will forever alter his life.",
			ReleaseDate = new DateTime(2013,10,18),
			VoteAverage = 7.9m,
			VoteCount = 3787,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0070735",
			Title = "The Sting",
			Description = "Set in the 1930's this intricate caper deals with an ambitious small-time crook and a veteran con man who seek revenge on a vicious crime lord who murdered one of their gang.",
			ReleaseDate = new DateTime(1973,12,25),
			VoteAverage = 7.9m,
			VoteCount = 639,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1454029",
			Title = "The Help",
			Description = "Aibileen Clark is a middle-aged African-American maid who has spent her life raising white children and has recently lost her only son; Minny Jackson is an African-American maid who has often offended her employers despite her family's struggles with money and her desperate need for jobs; and Eugenia 'Skeeter' Phelan is a young white woman who has recently moved back home after graduating college to find out her childhood maid has mysteriously disappeared. These three stories intertwine to explain how life in Jackson, Mississippi revolves around 'the help,' yet they are always kept at a certain distance because of racial lines.",
			ReleaseDate = new DateTime(2011,8,9),
			VoteAverage = 7.9m,
			VoteCount = 1966,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://thehelpmovie.com/#/splash"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1392214",
			Title = "Prisoners",
			Description = "When Keller Dover's daughter and her friend go missing, he takes matters into his own hands as the police pursue multiple leads and the pressure mounts. But just how far will this desperate father go to protect his family?",
			ReleaseDate = new DateTime(2013,9,18),
			VoteAverage = 7.9m,
			VoteCount = 3183,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://prisonersmovie.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0078748",
			Title = "Alien",
			Description = "During its return to the earth, commercial spaceship Nostromo intercepts a distress signal from a distant planet. When a three-member team of the crew discovers a chamber containing thousands of eggs on the planet, a creature inside one of the eggs attacks an explorer. The entire crew is unaware of the impending nightmare set to descend upon them when the alien parasite planted inside its unfortunate host is birthed.",
			ReleaseDate = new DateTime(1979,5,25),
			VoteAverage = 7.9m,
			VoteCount = 4564,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Horror"),
			Rating = Rating.R,
			URL = "https://www.facebook.com/alienanthology/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0167261",
			Title = "The Lord of the Rings: The Two Towers",
			Description = "Frodo and Sam are trekking to Mordor to destroy the One Ring of Power while Gimli, Legolas and Aragorn search for the orc-captured Merry and Pippin. All along, nefarious wizard Saruman awaits the Fellowship members at the Orthanc Tower in Isengard.",
			ReleaseDate = new DateTime(2002,12,18),
			VoteAverage = 8m,
			VoteCount = 7641,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = "http://www.lordoftherings.net/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120737",
			Title = "The Lord of the Rings: The Fellowship of the Ring",
			Description = "Young hobbit Frodo Baggins, after inheriting a mysterious ring from his uncle Bilbo, must leave his home in order to keep it from falling into the hands of its evil creator. Along the way, a fellowship is formed to protect the ringbearer and make sure that the ring arrives at its final destination: Mt. Doom, the only place where it can be destroyed.",
			ReleaseDate = new DateTime(2001,12,18),
			VoteAverage = 8m,
			VoteCount = 8892,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.lordoftherings.net/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0110357",
			Title = "The Lion King",
			Description = "A young lion cub named Simba can't wait to be king. But his uncle craves the title for himself and will stop at nothing to get it.",
			ReleaseDate = new DateTime(1994,6,23),
			VoteAverage = 8m,
			VoteCount = 5520,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Animation"),
			Rating = Rating.G,
			URL = "http://movies.disney.com/the-lion-king"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0088763",
			Title = "Back to the Future",
			Description = "Eighties teenager Marty McFly is accidentally sent back in time to 1955, inadvertently disrupting his parents' first meeting and attracting his mother's romantic interest. Marty must repair the damage to history by rekindling his parents' romance and - with the help of his eccentric inventor friend Doc Brown - return to 1985.",
			ReleaseDate = new DateTime(1985,7,3),
			VoteAverage = 8m,
			VoteCount = 6239,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG,
			URL = "http://www.backtothefuture.com/movies/backtothefuture1"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2084970",
			Title = "The Imitation Game",
			Description = "Based on the real life story of legendary cryptanalyst Alan Turing, the film portrays the nail-biting race against time by Turing and his brilliant team of code-breakers at Britain's top-secret Government Code and Cypher School at Bletchley Park, during the darkest days of World War II.",
			ReleaseDate = new DateTime(2014,11,14),
			VoteAverage = 8m,
			VoteCount = 5895,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://theimitationgamemovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt2278388",
			Title = "The Grand Budapest Hotel",
			Description = "The Grand Budapest Hotel tells of a legendary concierge at a famous European hotel between the wars and his friendship with a young employee who becomes his trusted protege. The story involves the theft and recovery of a priceless Renaissance painting, the battle for an enormous family fortune and the slow and then sudden upheavals that transformed Europe during the first half of the 20th century.",
			ReleaseDate = new DateTime(2014,2,26),
			VoteAverage = 8m,
			VoteCount = 4644,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt3741834",
			Title = "Lion",
			Description = "A five-year-old Indian boy gets lost on the streets of Calcutta, thousands of kilometers from home. He survives many challenges before being adopted by a couple in Australia. 25 years later, he sets out to find his lost family.",
			ReleaseDate = new DateTime(2016,11,24),
			VoteAverage = 8m,
			VoteCount = 1699,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://lionmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0482571",
			Title = "The Prestige",
			Description = "A mysterious story of two magicians whose intense rivalry leads them on a life-long battle for supremacy -- full of obsession, deceit and jealousy with dangerous and deadly consequences.",
			ReleaseDate = new DateTime(2006,10,19),
			VoteAverage = 8m,
			VoteCount = 4510,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Mystery"),
			Rating = Rating.PG13,
			URL = "http://wwws.warnerbros.de/theprestige/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0167260",
			Title = "The Lord of the Rings: The Return of the King",
			Description = "Aragorn is revealed as the heir to the ancient kings as he, Gandalf and the other members of the broken fellowship struggle to save Gondor from Sauron's forces. Meanwhile, Frodo and Sam bring the ring closer to the heart of Mordor, the dark lord's realm.",
			ReleaseDate = new DateTime(2003,12,1),
			VoteAverage = 8.1m,
			VoteCount = 8226,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.lordoftherings.net"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt1375666",
			Title = "Inception",
			Description = "Cobb, a skilled thief who commits corporate espionage by infiltrating the subconscious of his targets is offered a chance to regain his old life as payment for a task considered to be impossible: 'inception,' the implantation of another person's idea into a target's subconscious.",
			ReleaseDate = new DateTime(2010,7,14),
			VoteAverage = 8.1m,
			VoteCount = 14075,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Action"),
			Rating = Rating.PG13,
			URL = "http://inceptionmovie.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0076759",
			Title = "Star Wars",
			Description = "Princess Leia is captured and held hostage by the evil Imperial forces in their effort to take over the galactic Empire. Venturesome Luke Skywalker and dashing captain Han Solo team together with the loveable robot duo R2-D2 and C-3PO to rescue the beautiful princess and restore peace and justice in the Empire.",
			ReleaseDate = new DateTime(1977,5,25),
			VoteAverage = 8.1m,
			VoteCount = 6778,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Science Fiction"),
			Rating = Rating.PG,
			URL = "http://www.starwars.com/films/star-wars-episode-iv-a-new-hope"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0816692",
			Title = "Interstellar",
			Description = "Interstellar chronicles the adventures of a group of explorers who make use of a newly discovered wormhole to surpass the limitations on human space travel and conquer the vast distances involved in an interstellar voyage.",
			ReleaseDate = new DateTime(2014,11,5),
			VoteAverage = 8.1m,
			VoteCount = 11187,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG13,
			URL = "http://www.interstellarmovie.net/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0114369",
			Title = "Se7en",
			Description = "Two homicide detectives are on a desperate hunt for a serial killer whose crimes are based on the 'seven deadly sins' in this dark and haunting film that takes viewers from the tortured remains of one victim to the next. The seasoned Det. Sommerset researches each sin in an effort to get inside the killer's mind, while his novice partner, Mills, scoffs at his efforts to unravel the case.",
			ReleaseDate = new DateTime(1995,9,22),
			VoteAverage = 8.1m,
			VoteCount = 5915,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = "http://www.sevenmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0102926",
			Title = "The Silence of the Lambs",
			Description = "FBI trainee, Clarice Starling ventures into a maximum-security asylum to pick the diseased brain of Hannibal Lecter, a psychiatrist turned homicidal cannibal. Starling needs clues to help her capture a serial killer. but her Faustian relationship with Lecter soon leads to his escape, and now two deranged killers are on the loose.",
			ReleaseDate = new DateTime(1991,2,1),
			VoteAverage = 8.1m,
			VoteCount = 4549,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Crime"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0097165",
			Title = "Dead Poets Society",
			Description = "At an elite, old-fashioned boarding school in New England, a passionate English teacher inspires his students to rebel against convention and seize the potential of every day, courting the disdain of the stern headmaster.",
			ReleaseDate = new DateTime(1989,6,2),
			VoteAverage = 8.1m,
			VoteCount = 2786,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0253474",
			Title = "The Pianist",
			Description = "The Pianist is a film adapted from the biography of Wladyslaw Szpilman. A Jewish-Polish pianist who during the second world war lived and hid miraculously in Warsaw after having gone through a terrible tragedy. A film from Roman Polanski.",
			ReleaseDate = new DateTime(2002,9,24),
			VoteAverage = 8.1m,
			VoteCount = 1927,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.thepianistmovie.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0109830",
			Title = "Forrest Gump",
			Description = "A man with a low IQ has accomplished great things in his life and been present during significant historic events - in each case, far exceeding what anyone imagined he could do. Yet, despite all the things he has attained, his one true love eludes him. 'Forrest Gump' is the story of a man who rose above his challenges, and who proved that determination, courage, and love are more important than ability.",
			ReleaseDate = new DateTime(1994,7,6),
			VoteAverage = 8.2m,
			VoteCount = 8147,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Comedy"),
			Rating = Rating.PG13,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0080684",
			Title = "The Empire Strikes Back",
			Description = "The epic saga continues as Luke Skywalker, in hopes of defeating the evil Galactic Empire, learns the ways of the Jedi from aging master Yoda. But Darth Vader is more determined than ever to capture Luke. Meanwhile, rebel leader Princess Leia, cocky Han Solo, Chewbacca, and droids C-3PO and R2-D2 are thrown into various stages of capture, betrayal and despair.",
			ReleaseDate = new DateTime(1980,5,17),
			VoteAverage = 8.2m,
			VoteCount = 5998,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Adventure"),
			Rating = Rating.PG,
			URL = "http://www.starwars.com/films/star-wars-episode-v-the-empire-strikes-back"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0120689",
			Title = "The Green Mile",
			Description = "A supernatural tale set on death row in a Southern prison, where gentle giant John Coffey possesses the mysterious power to heal people's ailments. When the cellblock's head guard, Paul Edgecomb, recognizes Coffey's miraculous gift, he tries desperately to help stave off the condemned man's execution.",
			ReleaseDate = new DateTime(1999,12,10),
			VoteAverage = 8.2m,
			VoteCount = 4166,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://thegreenmile.warnerbros.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0468569",
			Title = "The Dark Knight",
			Description = "Batman raises the stakes in his war on crime. With the help of Lt. Jim Gordon and District Attorney Harvey Dent, Batman sets out to dismantle the remaining criminal organizations that plague the streets. The partnership proves to be effective, but they soon find themselves prey to a reign of chaos unleashed by a rising criminal mastermind known to the terrified citizens of Gotham as the Joker.",
			ReleaseDate = new DateTime(2008,7,16),
			VoteAverage = 8.3m,
			VoteCount = 12269,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.PG13,
			URL = "http://thedarkknight.warnerbros.com/dvdsite/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0108052",
			Title = "Schindler's List",
			Description = "The true story of how businessman Oskar Schindler saved over a thousand Jewish lives from the Nazis while they worked as slaves in his factory during World War II.",
			ReleaseDate = new DateTime(1993,11,29),
			VoteAverage = 8.3m,
			VoteCount = 4436,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.schindlerslist.com/"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0110912",
			Title = "Pulp Fiction",
			Description = "A burger-loving hit man, his philosophical partner, a drug-addled gangster's moll and a washed-up boxer converge in this sprawling, comedic crime caper. Their adventures unfurl in three stories that ingeniously trip back and forth in time.",
			ReleaseDate = new DateTime(1994,9,10),
			VoteAverage = 8.3m,
			VoteCount = 8670,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Thriller"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0073486",
			Title = "One Flew Over the Cuckoo's Nest",
			Description = "While serving time for insanity at a state mental hospital, implacable rabble-rouser, Randle Patrick McMurphy inspires his fellow patients to rebel against the authoritarian rule of head nurse, Mildred Ratched.",
			ReleaseDate = new DateTime(1975,11,18),
			VoteAverage = 8.3m,
			VoteCount = 3001,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = ""
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0137523",
			Title = "Fight Club",
			Description = "A ticking-time-bomb insomniac and a slippery soap salesman channel primal male aggression into a shocking new form of therapy. Their concept catches on, with underground 'fight clubs' forming in every town, until an eccentric gets in the way and ignites an out-of-control spiral toward oblivion.",
			ReleaseDate = new DateTime(1999,10,15),
			VoteAverage = 8.3m,
			VoteCount = 9678,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.foxmovies.com/movies/fight-club"
		});
		AllMovies.Add(new Movie
		{
			IMDBID = "tt0068646",
			Title = "The Godfather",
			Description = "Spanning the years 1945 to 1955, a chronicle of the fictional Italian-American Corleone crime family. When organized crime family patriarch, Vito Corleone barely survives an attempt on his life, his youngest son, Michael steps in to take care of the would-be killers, launching a campaign of bloody revenge.",
			ReleaseDate = new DateTime(1972,3,14),
			VoteAverage = 8.5m,
			VoteCount = 6024,
			Genre = db.Genres.FirstOrDefault(g => g.GenreName == "Drama"),
			Rating = Rating.R,
			URL = "http://www.thegodfather.com/"
		});

		//create some counters to help debug problems
		Int32 intMovieID = 0;
		String strMovieTitle = "Start";

		//loop through the list to add or update the movie
		try
		{
			foreach (Movie seedMovie in AllMovies)
			{
				//update the counters
				intMovieID = seedMovie.MovieID;
				strMovieTitle = seedMovie.Title;
				//see if the movie is already in the database using the IMDBID
				Movie dbMovie = db.Movies.FirstOrDefault(m => m.IMDBID == seedMovie.IMDBID);

					//if movie is null, movie is not in database
					if (dbMovie == null)
					{
						//Add the movie to the database
						db.Movies.Add(seedMovie);
						db.SaveChanges();
					}
					else //the movie is in the database - reset all fields except ID and IMDBID
					{
						dbMovie.Description = seedMovie.Description;
						dbMovie.Genre = seedMovie.Genre;
						dbMovie.ReleaseDate = seedMovie.ReleaseDate;
						dbMovie.Title = seedMovie.Title;
						dbMovie.URL = seedMovie.URL;
						dbMovie.VoteAverage = seedMovie.VoteAverage;
						dbMovie.VoteCount = seedMovie.VoteCount;
						db.SaveChanges();
					}
				}
			}
			catch (Exception ex) //throw error if there is a problem in the database
			{
				StringBuilder msg = new StringBuilder();
				msg.Append("There was a problem adding the movie with the title: ");
				msg.Append(strMovieTitle);
				msg.Append(" (MovieID: ");
				msg.Append(intMovieID);
				msg.Append(")");
				throw new Exception(msg.ToString(), ex);
			}
		}
	}
}
