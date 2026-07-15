using BCrypt.Net;

string hash =
BCrypt.Net.BCrypt.HashPassword(
    "reception123");

Console.WriteLine(hash);