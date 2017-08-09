# HtmlToXliff
programs to convert HTML to XLIFF 1.2 and back again using OASIS recommendation

These programs follow the "maximalist" representation described in the
[OASIS XLIFF 1.2 Representation Guide for HTML](http://docs.oasis-open.org/xliff/v1.2/xliff-profile-html/xliff-profile-html-1.2-cd02.html).
The implementation may be incomplete, but works for a wide range of HTML files.  One advantage of this approach is that it exposes
translatable attribute values such as the alt attribute of the img element.  Another advantange is that it does not require any
tagging or preprocessing of the HTML file.

The programs currently have a very minimal command line interface to the world.
