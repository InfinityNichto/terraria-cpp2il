using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Scripting.APIUpdating
{
	[global::Cpp2ILInjected.Token(Token = "0x2000100")]
	internal struct MovedFromAttributeData
	{
		[global::Cpp2ILInjected.Token(Token = "0x600054F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89EF0", Offset = "0x1F89EF0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Set(bool autoUpdateAPI, string sourceNamespace = null, string sourceAssembly = null, string sourceClassName = null)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000425")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public string className;

		[global::Cpp2ILInjected.Token(Token = "0x4000426")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public string nameSpace;

		[global::Cpp2ILInjected.Token(Token = "0x4000427")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string assembly;

		[global::Cpp2ILInjected.Token(Token = "0x4000428")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public bool classHasChanged;

		[global::Cpp2ILInjected.Token(Token = "0x4000429")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x19")]
		public bool nameSpaceHasChanged;

		[global::Cpp2ILInjected.Token(Token = "0x400042A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		public bool assemblyHasChanged;

		[global::Cpp2ILInjected.Token(Token = "0x400042B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B")]
		public bool autoUdpateAPI;
	}
}
