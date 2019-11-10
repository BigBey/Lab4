namespace Lab4.serialization.tokenization
{
    internal enum INITokenType : byte
    {
        None = 0,
        StartOfFile,
        StartOfSection,
        NameOfSection,
        EndOfSection,
        Name,
        Equals,
        Value,
        Comment,
        EndOfFile
    }
}