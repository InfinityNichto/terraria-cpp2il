using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	[global::Cpp2ILInjected.Token(Token = "0x20004D8")]
	public class ManifestResourceInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x60023B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B81E58", Offset = "0x1B81E58", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ManifestResourceInfo(Assembly containingAssembly, string containingFileName, ResourceLocation resourceLocation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004A7")]
		public virtual Assembly ReferencedAssembly
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60023B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B81E94", Offset = "0x1B81E94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004A8")]
		public virtual string FileName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60023B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B81E9C", Offset = "0x1B81E9C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004A9")]
		public virtual ResourceLocation ResourceLocation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60023B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B81EA4", Offset = "0x1B81EA4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40013B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Assembly <ReferencedAssembly>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40013B1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string <FileName>k__BackingField;

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40013B2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly ResourceLocation <ResourceLocation>k__BackingField;
	}
}
