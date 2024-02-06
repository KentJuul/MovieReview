using MovieReview.Core.Entity;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public static class FakeDB
{
    public static List<Movie> Movies()
    {
        var movies = new List<Movie>
        {
            new Movie
            {
                MovieID = 1,
                Title = "The Shawshank Redemption",
                Director = "Frank Darabont",
                ReleaseYear = 1994,
                Genres = new List<string> { "Drama" },
                Cast = new List<string> { "Tim Robbins", "Morgan Freeman" },
                Synopsis = "Two imprisoned men bond over a number of years, finding solace and eventual redemption through acts of common decency.",
                Rating = 9.3f,
                Runtime = 142,
                Language = "English",
                ImageUrl = "https://example.com/shawshank_redemption.jpg"
            },
            new Movie
            {
                MovieID = 2,
                Title = "The Godfather",
                Director = "Francis Ford Coppola",
                ReleaseYear = 1972,
                Genres = new List<string> { "Crime", "Drama" },
                Cast = new List<string> { "Marlon Brando", "Al Pacino" },
                Synopsis = "The aging patriarch of an organized crime dynasty transfers control of his clandestine empire to his reluctant son.",
                Rating = 9.2f,
                Runtime = 175,
                Language = "English",
                ImageUrl = "https://example.com/the_godfather.jpg"
            },
            new Movie
            {
                MovieID = 3,
                Title = "The Dark Knight",
                Director = "Christopher Nolan",
                ReleaseYear = 2008,
                Genres = new List<string> { "Action", "Crime", "Drama" },
                Cast = new List<string> { "Christian Bale", "Heath Ledger" },
                Synopsis = "When the menace known as The Joker emerges from his mysterious past, he wreaks havoc and chaos on the people of Gotham.",
                Rating = 9.0f,
                Runtime = 152,
                Language = "English",
                ImageUrl = "https://example.com/the_dark_knight.jpg"
            },
            new Movie
            {
                MovieID = 4,
                Title = "The Lord of the Rings: The Fellowship of the Ring",
                Director = "Peter Jackson",
                ReleaseYear = 2001,
                Genres = new List<string> { "Adventure", "Fantasy" },
                Cast = new List<string> { "Elijah Wood", "Ian McKellen", "Viggo Mortensen" },
                Synopsis = "A young hobbit, Frodo Baggins, embarks on a perilous journey to destroy a powerful ring and save Middle-earth from the dark lord Sauron.",
                Rating = 8.8f,
                Runtime = 178,
                Language = "English",
                ImageUrl = "https://example.com/lotr_fellowship.jpg"
            },
            new Movie
            {
                MovieID = 5,
                Title = "Inception",
                Director = "Christopher Nolan",
                ReleaseYear = 2010,
                Genres = new List<string> { "Action", "Adventure", "Sci-Fi" },
                Cast = new List<string> { "Leonardo DiCaprio", "Joseph Gordon-Levitt" },
                Synopsis = "A thief who enters the dreams of others to steal their secrets finds himself in a complex heist within the subconscious.",
                Rating = 8.8f,
                Runtime = 148,
                Language = "English",
                ImageUrl = "https://example.com/inception.jpg"
            },
            new Movie
            {
                MovieID = 6,
                Title = "The Matrix",
                Director = "The Wachowskis",
                ReleaseYear = 1999,
                Genres = new List<string> { "Action", "Sci-Fi" },
                Cast = new List<string> { "Keanu Reeves", "Laurence Fishburne" },
                Synopsis = "A computer hacker learns from mysterious rebels about the true nature of his reality and his role in the war against its controllers.",
                Rating = 8.7f,
                Runtime = 136,
                Language = "English",
                ImageUrl = "https://example.com/the_matrix.jpg"
            },
            new Movie
            {
                MovieID = 7,
                Title = "Forrest Gump",
                Director = "Robert Zemeckis",
                ReleaseYear = 1994,
                Genres = new List<string> { "Drama", "Romance" },
                Cast = new List<string> { "Tom Hanks", "Robin Wright" },
                Synopsis = "The life of Forrest Gump, a man with a low IQ, who inadvertently influences many historical events in the United States.",
                Rating = 8.8f,
                Runtime = 142,
                Language = "English",
                ImageUrl = "https://example.com/forrest_gump.jpg"
            },
            new Movie
            {
                MovieID = 8,
                Title = "Interstellar",
                Director = "Christopher Nolan",
                ReleaseYear = 2014,
                Genres = new List<string> { "Adventure", "Drama", "Sci-Fi" },
                Cast = new List<string> { "Matthew McConaughey", "Anne Hathaway" },
                Synopsis = "A group of explorers travel through a wormhole in space in an attempt to ensure humanity's survival.",
                Rating = 8.6f,
                Runtime = 169,
                Language = "English",
                ImageUrl = "https://example.com/interstellar.jpg"
            },
            new Movie
            {
                MovieID = 9,
                Title = "Pulp Fiction",
                Director = "Quentin Tarantino",
                ReleaseYear = 1994,
                Genres = new List<string> { "Crime", "Drama" },
                Cast = new List<string> { "John Travolta", "Samuel L. Jackson" },
                Synopsis = "The lives of two mob hitmen, a boxer, a gangster's wife, and a pair of diner bandits intertwine in four tales of violence and redemption.",
                Rating = 8.9f,
                Runtime = 154,
                Language = "English",
                ImageUrl = "https://example.com/pulp_fiction.jpg"
            },
            new Movie
            {
                MovieID = 10,
                Title = "Star Wars: Episode III - Revenge of the Sith",
                Director = "George Lucas",
                ReleaseYear = 2005,
                Genres = new List<string> { "Adventure", "Drama", "Sci-Fi" },
                Cast = new List<string> { "Ewan McGregor", "Hayden Christensen" },
                Synopsis = "Three years into the Clone Wars, Obi-Wan pursues a new threat, while Anakin is lured by Chancellor Palpatine into a sinister plot to rule the galaxy..",
                Rating = 7.6f,
                Runtime = 142,
                Language = "English",
                ImageUrl = "https://example.com/shawshank_redemption.jpg"
            }

        };

        return movies;
    }

    public static List<Review> Reviews()
    {
        var reviews = new List<Review>
        {
            new Review
            {
                ReviewID = 1,
                MovieID = 1,
                Author = "John Doe",
                Rating = 5,
                Comment = "An exceptional movie with outstanding performances. A must-watch!",
                Date = new DateTime(2024, 1, 15)
            },
            new Review
            {
                ReviewID = 2,
                MovieID = 2,
                Author = "Jane Smith",
                Rating = 5,
                Comment = "A classic masterpiece. Marlon Brando and Al Pacino are phenomenal.",
                Date = new DateTime(2024, 1, 20)
            },
            new Review
            {
                ReviewID = 3,
                MovieID = 3,
                Author = "Mike Johnson",
                Rating = 4,
                Comment = "Intense and captivating. Heath Ledger's Joker is iconic.",
                Date = new DateTime(2024, 1, 25)
            },
            new Review
            {
                ReviewID = 4,
                MovieID = 4,
                Author = "Sarah Lee",
                Rating = 4,
                Comment = "An epic journey into a rich fantasy world. Stunning visuals.",
                Date = new DateTime(2024, 2, 1)
            },
            new Review
            {
                ReviewID = 5,
                MovieID = 5,
                Author = "David Wilson",
                Rating = 5,
                Comment = "A mind-bending experience. Nolan at his best.",
                Date = new DateTime(2024, 2, 5)
            },
            new Review
            {
                ReviewID = 6,
                MovieID = 6,
                Author = "Emily Brown",
                Rating = 4,
                Comment = "Groundbreaking special effects and an intriguing plot.",
                Date = new DateTime(2024, 2, 10)
            },
            new Review
            {
                ReviewID = 7,
                MovieID = 7,
                Author = "Chris Green",
                Rating = 5,
                Comment = "Heartwarming and inspiring. Tom Hanks delivers an unforgettable performance.",
                Date = new DateTime(2024, 2, 15)
            },
            new Review
            {
                ReviewID = 8,
                MovieID = 8,
                Author = "Laura Martinez",
                Rating = 4,
                Comment = "A visually stunning and deeply emotional space odyssey.",
                Date = new DateTime(2024, 2, 20)
            },
            new Review
            {
                ReviewID = 9,
                MovieID = 9,
                Author = "Alex Turner",
                Rating = 5,
                Comment = "Tarantino's storytelling is unique and engaging. A cult classic.",
                Date = new DateTime(2024, 2, 25)
            },
            new Review
            {
                ReviewID = 10,
                MovieID = 10, 
                Author = "Obi Wan Kenobi",
                Rating = 5,
                Comment = "Hello there",
                Date = new DateTime(2024, 3, 1)
            }
        };

        return reviews;
    }
    
}
