using Elastic.Xunit.XunitPlumbing;
using Nest;

namespace Examples.XPack.Docs.En.Watcher
{
	public class GettingStartedPage : ExampleBase
	{
		[U(Skip = "Example not implemented")]
		public void Line32()
		{
			// tag::a45eb0cdd138d9c894ca2de9352549a1[]
			var response0 = new SearchResponse<object>();
			// end::a45eb0cdd138d9c894ca2de9352549a1[]

			response0.MatchesExample(@"PUT _watcher/watch/log_error_watch
			{
			  ""trigger"" : {
			    ""schedule"" : { ""interval"" : ""10s"" } <1>
			  },
			  ""input"" : {
			    ""search"" : {
			      ""request"" : {
			        ""indices"" : [ ""logs"" ],
			        ""body"" : {
			          ""query"" : {
			            ""match"" : { ""message"": ""error"" }
			          }
			        }
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line66()
		{
			// tag::69d9b8fd364596aa37eae6864d8a6d89[]
			var response0 = new SearchResponse<object>();
			// end::69d9b8fd364596aa37eae6864d8a6d89[]

			response0.MatchesExample(@"GET .watcher-history*/_search?pretty
			{
			  ""sort"" : [
			    { ""result.execution_time"" : ""desc"" }
			  ]
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line89()
		{
			// tag::c42ee13e461422d242c94332d3c38f87[]
			var response0 = new SearchResponse<object>();
			// end::c42ee13e461422d242c94332d3c38f87[]

			response0.MatchesExample(@"PUT _watcher/watch/log_error_watch
			{
			  ""trigger"" : { ""schedule"" : { ""interval"" : ""10s"" }},
			  ""input"" : {
			    ""search"" : {
			      ""request"" : {
			        ""indices"" : [ ""logs"" ],
			        ""body"" : {
			          ""query"" : {
			            ""match"" : { ""message"": ""error"" }
			          }
			        }
			      }
			    }
			  },
			  ""condition"" : {
			    ""compare"" : { ""ctx.payload.hits.total.value"" : { ""gt"" : 0 }} <1>
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line119()
		{
			// tag::1414d40bb1e9d7644b72245bbb5ec834[]
			var response0 = new SearchResponse<object>();
			// end::1414d40bb1e9d7644b72245bbb5ec834[]

			response0.MatchesExample(@"POST logs/_doc
			{
			    ""timestamp"" : ""2015-05-17T18:12:07.613Z"",
			    ""request"" : ""GET index.html"",
			    ""status_code"" : 404,
			    ""message"" : ""Error: File not found""
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line136()
		{
			// tag::9aa2327ae315c39f2bce2bd22e0deb1b[]
			var response0 = new SearchResponse<object>();
			// end::9aa2327ae315c39f2bce2bd22e0deb1b[]

			response0.MatchesExample(@"GET .watcher-history*/_search?pretty
			{
			  ""query"" : {
			    ""bool"" : {
			      ""must"" : [
			        { ""match"" : { ""result.condition.met"" : true }},
			        { ""range"" : { ""result.execution_time"" : { ""from"" : ""now-10s"" }}}
			      ]
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line166()
		{
			// tag::6a832c7eb7db40b21ab9848d3af19536[]
			var response0 = new SearchResponse<object>();
			// end::6a832c7eb7db40b21ab9848d3af19536[]

			response0.MatchesExample(@"PUT _watcher/watch/log_error_watch
			{
			  ""trigger"" : { ""schedule"" : { ""interval"" : ""10s"" }},
			  ""input"" : {
			    ""search"" : {
			      ""request"" : {
			        ""indices"" : [ ""logs"" ],
			        ""body"" : {
			          ""query"" : {
			            ""match"" : { ""message"": ""error"" }
			          }
			        }
			      }
			    }
			  },
			  ""condition"" : {
			    ""compare"" : { ""ctx.payload.hits.total.value"" : { ""gt"" : 0 }}
			  },
			  ""actions"" : {
			    ""log_error"" : {
			      ""logging"" : {
			        ""text"" : ""Found {{ctx.payload.hits.total.value}} errors in the logs""
			      }
			    }
			  }
			}");
		}

		[U(Skip = "Example not implemented")]
		public void Line207()
		{
			// tag::67a490d749a0c3bb16a266663423893d[]
			var response0 = new SearchResponse<object>();
			// end::67a490d749a0c3bb16a266663423893d[]

			response0.MatchesExample(@"DELETE _watcher/watch/log_error_watch");
		}
	}
}