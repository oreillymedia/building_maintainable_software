Building Maintainable Software
==========

This is the example code that accompanies _Building Maintainable Software: Ten Guidelines for Future-Proof Code_ by Joost Visser.

There are currently two editions of _Building Maintainable Software_:
- The Java edition (ISBN print: 978-1-4919-5352-5, ISBN eBook: 978-1-4919-5348-8), available [at the O'Reilly webshop](http://shop.oreilly.com/product/0636920049159.do) and [at Amazon](http://www.amazon.com/Building-Maintainable-Software-Java-Edition-ebook/dp/B01B6WS86I).
- The C# edition, currently submitted as a manuscript to O'Reilly Media.

[Training videos](http://oreil.ly/1OVw1PM) are also available via O'Reilly Media.

Both editions are the same except for the language of the code snippets and a bit of language-specific terminology (e.g., 'Eclipse' in the Java edition is 'Visual Studio' in the C# edition).

Click the Download Zip button to the right to download example code.

See an error? Report it [here](http://oreilly.com/catalog/errata.csp?isbn=9781491940662) for the Java edition, or simply fork and send us a pull request.

About The Example Code
-----------

The example code of the Java edition lives in `src/java` and `src/test/java`. The example code of the C# edition lives in `src/csharp` and `src/test/csharp`. Every `.java` file in `src/java` has a `.cs` file with the same name in `src/csharp` and the other way around. The same is true for the contents of the `src/test` directories.

For the Java code, there is a `pom.xml` file in the root of this repository. This allows compiling the Java source files and running the unit tests using [Maven](https://maven.apache.org) by executing `mvn test`.

For the C# code, there is a Visual Studio Solution file in the root of this repository, which references two projects (see the `.csproj` files in `src/csharp` and `src/test/csharp`). We compile the C# code and run the unit tests regularly using [Mono](http://www.mono-project.com) on MacOS and occasionally using Visual Studio.

Both the Java and the C# editions have been written using O'Reilly's [Atlas](https://atlas.oreilly.com) platform in the [AsciiDoc](http://asciidoc.org) markup language. All code snippets displayed in the books are taken directly from this example code. The parts included in the books are between Java and C# comments of the form `// tag::NameOfTag[]` and `// end::NameOfTag[]`. All code not between such comments is just there to make everything compile and pass unit tests.
