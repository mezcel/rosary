# Windows.NET Rosary Prayer Community (App Development)

Developed on Visual Studio with MySql Connector ADO.NET Plugin

I am making a web page just to illustrate the organization and purpose of this coding project.
http://mezcel.wixsite.com/rosary

If your are a devloper, I recomend installing "XAML Regions" It is free from Microsoft and designed for Visual Studio 12-15 

"XAML Regions"
A small extension that adds the ability to define collapsable regions in XAML & XML code. It recognizes region definitions that are defined inside of XML comments so that code designed using this extension will have no problems compiling in environments that do not have this extension.

https://visualstudiogallery.msdn.microsoft.com/3c534623-bb05-417f-afc0-c9e26bf0e177


[Sites Using React](https://github.com/mezcel/rosary/wiki)

[My Awesome Wiki](https://github.com/mezcel/rosary/wiki)


<div class="begin-examples"></div>
And we should also tell it where the two column layout ends.

<div class="end-examples"></div>
h2 will be an example section header.

## Section title
And any text directly after the section title will not be split into two columns.

## Section title
This text, along with the title, remains in a single column
Each point in a section starts with an h3.

### Main you want to make point here
Normal text elements (p) are used for more detailed explanations.

You can put them after the main point.

### Main point
Some explanatory text.
Code is interleaved with explanatory text.

The main point or explanation for a piece of code should come directly before it.

### Main point about code block 1

```
code block 1
```

More text explaining code block 2

```
code block 2
```
Styling

We can use CSS to style the Markdown output to create a two column layout when readers view our page on a larger screen.

The main section and subsection headings both take up the entire width of the page.

article .begin-examples ~ h2,
article .begin-examples ~ h2 + p {
    width: 100%;
    clear: both;
}
Each column element is 50% width

article .begin-examples ~ h3,
article .begin-examples ~ p,
article .begin-examples ~ .highlight {
    width: 50%;
}
The left column has the main point and explanation text (h3 and p).

We'll add some padding here too for good measure.

article .begin-examples ~ h3,
article .begin-examples ~ p {
    float: left;
    box-sizing: border-box;
    padding-right: 1rem;
    clear: both;
}
While the right column has only the code examples .highlight.

And some spacing between the sections.

article .begin-examples ~ .highlight {
    float: right;
    clear: right;
    margin-bottom: 1rem;
}
That's it!

But we have to ensure that nothing goes past the end of content.

.end-examples {
    clear: both;
}
But we should clean up after ourselves.

Reset the styles to stop the two column layout. This must come after all the other styles in the CSS file.

article .end-examples ~ p,
article .end-examples ~ h3,
article .end-examples ~ .highlight {
    width: auto;
    float: none;
    clear: none;
}
Style For Small Screens

Using a media query on screens less that 580px in width, we'll create a single column layout again.

All you have to do is reset the styling on the main elements of the two column layout

article .begin-examples ~ h3,
article .begin-examples ~ p,
article .begin-examples ~ .highlight {
    width: 100%;
    float: none;
    clear: none;
}
