namespace MoviesApi.Contracts;

public sealed record CreateMovieRequest(string Title, int ReleaseYear, int Duration);