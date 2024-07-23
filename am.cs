public class StringApiBuilder
{
    // ... Other properties and methods ...

    public virtual StringApiBuilder Get => this;
}

public class CustomStringApiBuilder : StringApiBuilder
{
    // ... Additional properties and methods ...
}

// Usage
CustomStringApiBuilder builder = new CustomStringApiBuilder();
StringApiBuilder result = builder.Get;

// The 'result' variable will hold the 'builder' object itself (instance of CustomStringApiBuilder)
