#pragma warning disable 1591
// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 4.0.30319.17020
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CodeBucket.Views
{
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[System.CodeDom.Compiler.GeneratedCodeAttribute("RazorTemplatePreprocessor", "2.6.0.0")]
public partial class CommentsRazorView : CommentsRazorViewBase
{

#line hidden

#line 1 "CommentsRazorView.cshtml"
public List<CommentViewModel> Model { get; set; }

#line default
#line hidden


public override void Execute()
{
WriteLiteral("<html><head>\n<meta");

WriteLiteral(" name=\"viewport\"");

WriteLiteral(" content=\"width=device-width; initial-scale=1.0; maximum-scale=1.0; user-scalable" +
"=0\"");

WriteLiteral("/>\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\nfunction size() { return document.getElementById(\'main\').scrollHeight + 0; }\nfu" +
"nction rs() { document.location.href = \'app://resize\'; }; window.onsize = rs;\nva" +
"r h = 0; setInterval(function() { if (size() != h) { h = size(); rs(); } }, 100)" +
";\n</script>\n<style>\n* {\n-webkit-touch-callout: none;\n-webkit-user-select: none;\n" +
"\n}\n\nhtml {\n    -webkit-text-size-adjust: none;\n}\n\nbody{\n    font-family: Helveti" +
"ca; \n    font-size: 12px; \n    margin: 0px;\n    word-wrap: break-word;\n}\n\na {\n  " +
"  color: #406fb9;\n    text-decoration: none;\n}\n\n#main {\n    padding: 0 0 10px 0;" +
"\n}\n\n#main > .comment:first-child {\nborder-top: none;\n}\n\n#main > .comment {\n    b" +
"order-top: 1px solid #c8c8c8;\n    padding: 8px 0 0 0;\n}\n\n#main > .comment > img " +
"{\n    position: absolute;\n    border-radius: 16px;\n    margin-left: 8px;\n    mar" +
"gin-top: 1px;\n    margin-bottom: 8px;\n    width: 32px;\n    height: 32px;\n}\n\n#mai" +
"n > .comment > div {\nmargin-left: 48px;\nmargin-right: 8px;\n}\n\n#main > .comment >" +
" div > h1 {\nfont-size: 1.6em;\nmargin: 0;\ncolor: #406fb9;\nwhite-space: nowrap;\nov" +
"erflow: hidden;\n}\n\n#main > .comment > div > h2 {\nfont-size: 1.2em;\nmargin: 0 0 4" +
"px 0;\nfont-weight: normal;\ncolor: #404040;\nwhite-space: nowrap;\noverflow: hidden" +
";\n}\n\n#main > .comment > div > div {\nmargin: 0;\nword-wrap: break-word;\n}\n\n#main >" +
" .comment > div > .mark {\n    margin-top: 8px;\n    margin-bottom: 8px;\n    margi" +
"n-right: 8px;\n}\n\n#main > .comment > div > div img {\nmax-width: 100%;\n}\n\n#main { " +
"width: 100%; }\n\nimg { max-width: 100%; } \np { margin: 10px 0; white-space: pre-w" +
"rap; } \npre, li, ul { word-wrap: break-word; } \n\n.mark h1, .mark h2, .mark h3, ." +
"mark h4, .mark h5, .mark h6 {\nmargin: 1em 0 15px;\npadding: 0;\nfont-weight: bold;" +
"\nline-height: 1.7;\ncursor: text;\nposition: relative;\n}\n\nul, ol {\npadding: 0;\nmar" +
"gin-top: 0;\nmargin-bottom: 0;\npadding-left: 20px;\n}\n\npre {\nbackground-color: #f8" +
"f8f8;\nborder: 1px solid #ddd;\nline-height: 19px;\noverflow: auto;\npadding: 6px 10" +
"px;\nborder-radius: 3px;\nword-wrap: normal;\n}\ndl dt {\nfont-weight: bold;\nfont-sty" +
"le: italic;\npadding: 0;\nmargin-top: 15px;\n}\nblockquote {\nborder-left: 4px solid " +
"#DDD;\npadding: 0 15px;\ncolor: #777;\n}\ntable {\nwidth: 100%;\noverflow: auto;\ndispl" +
"ay: block;\n}\ntable tr {\nborder-top: 1px solid #ccc;\nbackground-color: #fff;\n}\nta" +
"ble th {\nfont-weight: bold;\n}\ntable th, table td {\nborder: 1px solid #d9d9e0;\nbo" +
"rder: 0.5px solid #d9d9d9;\npadding: 4px 11px;\n}\ntable tr:nth-child(2n) {\nbackgro" +
"und-color: #f8f8f8;\n}\n.mark h2 {\nfont-size: 1.2em;\nborder-bottom: 1px solid #eee" +
";\n}\n.mark h1 {\nfont-size: 1.6em;\nborder-bottom: 1px solid #ddd;\n}\n\n.mark .label " +
"{\ndisplay: inline;\npadding: .2em .6em .2em;\nfont-size: 85%;\nfont-weight: 700;\nli" +
"ne-height: 1;\ncolor: #fff;\ntext-align: center;\nwhite-space: nowrap;\nvertical-ali" +
"gn: baseline;\nborder-radius: .25em;\n}\n.label-danger {\nbackground-color: #d9534f;" +
"\n}\n.label-success {\nbackground-color: #5cb85c;\n}\n.label-info {\nbackground-color:" +
" #6e5494;\n}\n.label-default {\nbackground-color: #999;\n}\nul.task-list > li.task-li" +
"st-item {\n  list-style-type: none;\n}\n.task-list-item-checkbox {\n  margin-left: -" +
"20px;\n  vertical-align: middle;\n}\n</style>\n</head>\n    <body>\n        <div");

WriteLiteral(" id=\"main\"");

WriteLiteral(">\n");


#line 198 "CommentsRazorView.cshtml"
            

#line default
#line hidden

#line 198 "CommentsRazorView.cshtml"
             foreach (var x in Model)
            {


#line default
#line hidden
WriteLiteral("                <div");

WriteLiteral(" class=\'comment\'");

WriteLiteral("><img");

WriteAttribute ("src", " src=\"", "\""

#line 200 "CommentsRazorView.cshtml"
        , Tuple.Create<string,object,bool> ("", x.AvatarUrl

#line default
#line hidden
, false)
);
WriteLiteral("><div><h1>");


#line 200 "CommentsRazorView.cshtml"
                                                                 Write(x.Title);


#line default
#line hidden
WriteLiteral("</h1><span>");


#line 200 "CommentsRazorView.cshtml"
                                                                                    Write(x.Created);


#line default
#line hidden
WriteLiteral("</span>\n                <div");

WriteLiteral(" class=\'mark\'");

WriteLiteral(">");


#line 201 "CommentsRazorView.cshtml"
                                    WriteLiteral(x.Content);

#line default
#line hidden
WriteLiteral("</div></div></div>\n");


#line 202 "CommentsRazorView.cshtml"
            }


#line default
#line hidden
WriteLiteral("        </div>\n    </body>\n</html>\n\n\n");

}
}

// NOTE: this is the default generated helper class. You may choose to extract it to a separate file 
// in order to customize it or share it between multiple templates, and specify the template's base 
// class via the @inherits directive.
public abstract class CommentsRazorViewBase
{

		// This field is OPTIONAL, but used by the default implementation of Generate, Write, WriteAttribute and WriteLiteral
		//
		System.IO.TextWriter __razor_writer;

		// This method is OPTIONAL
		//
		/// <summary>Executes the template and returns the output as a string.</summary>
		/// <returns>The template output.</returns>
		public string GenerateString ()
		{
			using (var sw = new System.IO.StringWriter ()) {
				Generate (sw);
				return sw.ToString ();
			}
		}

		// This method is OPTIONAL, you may choose to implement Write and WriteLiteral without use of __razor_writer
		// and provide another means of invoking Execute.
		//
		/// <summary>Executes the template, writing to the provided text writer.</summary>
		/// <param name="writer">The TextWriter to which to write the template output.</param>
		public void Generate (System.IO.TextWriter writer)
		{
			__razor_writer = writer;
			Execute ();
			__razor_writer = null;
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the template output without HTML escaping it.</summary>
		/// <param name="value">The literal value.</param>
		protected void WriteLiteral (string value)
		{
			__razor_writer.Write (value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes a literal value to the TextWriter without HTML escaping it.</summary>
		/// <param name="writer">The TextWriter to which to write the literal.</param>
		/// <param name="value">The literal value.</param>
		protected static void WriteLiteralTo (System.IO.TextWriter writer, string value)
		{
			writer.Write (value);
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>Writes a value to the template output, HTML escaping it if necessary.</summary>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected void Write (object value)
		{
			WriteTo (__razor_writer, value);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>Writes an object value to the TextWriter, HTML escaping it if necessary.</summary>
		/// <param name="writer">The TextWriter to which to write the value.</param>
		/// <param name="value">The value.</param>
		/// <remarks>The value may be a Action<System.IO.TextWriter>, as returned by Razor helpers.</remarks>
		protected static void WriteTo (System.IO.TextWriter writer, object value)
		{
			if (value == null)
				return;

			var write = value as Action<System.IO.TextWriter>;
			if (write != null) {
				write (writer);
				return;
			}

			//NOTE: a more sophisticated implementation would write safe and pre-escaped values directly to the
			//instead of double-escaping. See System.Web.IHtmlString in ASP.NET 4.0 for an example of this.
			writer.Write(System.Net.WebUtility.HtmlEncode (value.ToString ()));
		}

		// This method is REQUIRED, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to the template output.
		/// </summary>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		protected void WriteAttribute (string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			WriteAttributeTo (__razor_writer, name, prefix, suffix, values);
		}

		// This method is REQUIRED if the template contains any Razor helpers, but you may choose to implement it differently
		//
		/// <summary>
		/// Conditionally writes an attribute to a TextWriter.
		/// </summary>
		/// <param name="writer">The TextWriter to which to write the attribute.</param>
		/// <param name="name">The name of the attribute.</param>
		/// <param name="prefix">The prefix of the attribute.</param>
		/// <param name="suffix">The suffix of the attribute.</param>
		/// <param name="values">Attribute values, each specifying a prefix, value and whether it's a literal.</param>
		///<remarks>Used by Razor helpers to write attributes.</remarks>
		protected static void WriteAttributeTo (System.IO.TextWriter writer, string name, string prefix, string suffix, params Tuple<string,object,bool>[] values)
		{
			// this is based on System.Web.WebPages.WebPageExecutingBase
			// Copyright (c) Microsoft Open Technologies, Inc.
			// Licensed under the Apache License, Version 2.0
			if (values.Length == 0) {
				// Explicitly empty attribute, so write the prefix and suffix
				writer.Write (prefix);
				writer.Write (suffix);
				return;
			}

			bool first = true;
			bool wroteSomething = false;

			for (int i = 0; i < values.Length; i++) {
				Tuple<string,object,bool> attrVal = values [i];
				string attPrefix = attrVal.Item1;
				object value = attrVal.Item2;
				bool isLiteral = attrVal.Item3;

				if (value == null) {
					// Nothing to write
					continue;
				}

				// The special cases here are that the value we're writing might already be a string, or that the 
				// value might be a bool. If the value is the bool 'true' we want to write the attribute name instead
				// of the string 'true'. If the value is the bool 'false' we don't want to write anything.
				//
				// Otherwise the value is another object (perhaps an IHtmlString), and we'll ask it to format itself.
				string stringValue;
				bool? boolValue = value as bool?;
				if (boolValue == true) {
					stringValue = name;
				} else if (boolValue == false) {
					continue;
				} else {
					stringValue = value as string;
				}

				if (first) {
					writer.Write (prefix);
					first = false;
				} else {
					writer.Write (attPrefix);
				}

				if (isLiteral) {
					writer.Write (stringValue ?? value);
				} else {
					WriteTo (writer, stringValue ?? value);
				}
				wroteSomething = true;
			}
			if (wroteSomething) {
				writer.Write (suffix);
			}
		}
		// This method is REQUIRED. The generated Razor subclass will override it with the generated code.
		//
		///<summary>Executes the template, writing output to the Write and WriteLiteral methods.</summary>.
		///<remarks>Not intended to be called directly. Call the Generate method instead.</remarks>
		public abstract void Execute ();

}
}
#pragma warning restore 1591
