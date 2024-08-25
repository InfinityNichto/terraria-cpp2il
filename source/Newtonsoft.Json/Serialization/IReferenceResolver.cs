using System;
using Cpp2ILInjected;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Serialization
{
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x20000A4")]
	public interface IReferenceResolver
	{
		[global::Cpp2ILInjected.Token(Token = "0x60005E3")]
		object ResolveReference(object context, string reference);

		[global::Cpp2ILInjected.Token(Token = "0x60005E4")]
		string GetReference(object context, object value);

		[global::Cpp2ILInjected.Token(Token = "0x60005E5")]
		bool IsReferenced(object context, object value);

		[global::Cpp2ILInjected.Token(Token = "0x60005E6")]
		void AddReference(object context, string reference, object value);
	}
}
