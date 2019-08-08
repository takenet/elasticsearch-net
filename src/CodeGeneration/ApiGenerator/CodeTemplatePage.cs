using System;
using System.Threading.Tasks;
using RazorLight;

namespace ApiGenerator 
{
	/// <summary> This only exists to make the IDE tooling happy, not actually used to render the templates </summary>
	public class CodeTemplatePage<TModel> : TemplatePage<TModel>
	{
		public override async Task ExecuteAsync() => await Task.CompletedTask;

		public async Task Execute() => await Task.CompletedTask;
	}
}