using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001E2 RID: 482
	[global::Cpp2ILInjected.Token(Token = "0x2000267")]
	[global::System.Serializable]
	public sealed class DecoderReplacementFallback : DecoderFallback, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06001304 RID: 4868 RVA: 0x00017A5C File Offset: 0x00015C5C
		[global::Cpp2ILInjected.Token(Token = "0x60014BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB2498", Offset = "0x1CB2498", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DecoderFallback), Member = "get_ReplacementFallback", ReturnType = typeof(DecoderFallback))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DecoderReplacementFallback), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public DecoderReplacementFallback()
		{
			throw null;
		}

		// Token: 0x06001305 RID: 4869 RVA: 0x00017A5F File Offset: 0x00015C5F
		[global::Cpp2ILInjected.Token(Token = "0x60014BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB36E8", Offset = "0x1CB36E8", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		internal DecoderReplacementFallback(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001306 RID: 4870 RVA: 0x00017A62 File Offset: 0x00015C62
		[global::Cpp2ILInjected.Token(Token = "0x60014C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB37E0", Offset = "0x1CB37E0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001307 RID: 4871 RVA: 0x00017A65 File Offset: 0x00015C65
		[global::Cpp2ILInjected.Token(Token = "0x60014C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB354C", Offset = "0x1CB354C", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DecoderReplacementFallback), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF32Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UTF8Encoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnicodeEncoding), Member = "SetDefaultFallbacks", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.IriHelper", Member = "EscapeUnescapeIri", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.UriComponents"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.UriHelper", Member = "UnescapeString", MemberParameters = new object[]
		{
			"System.Char*",
			typeof(int),
			typeof(int),
			"System.Char[]",
			typeof(ref int),
			typeof(char),
			typeof(char),
			typeof(char),
			"System.UnescapeMode",
			"System.UriParser",
			typeof(bool)
		}, ReturnType = "System.Char[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextAsset.EncodingUtility", Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsSurrogate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "IsHighSurrogate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public DecoderReplacementFallback(string replacement)
		{
			throw null;
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06001308 RID: 4872 RVA: 0x00017A68 File Offset: 0x00015C68
		[global::Cpp2ILInjected.Token(Token = "0x1700020D")]
		public string DefaultString
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB383C", Offset = "0x1CB383C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001309 RID: 4873 RVA: 0x00017A6B File Offset: 0x00015C6B
		[global::Cpp2ILInjected.Token(Token = "0x60014C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3844", Offset = "0x1CB3844", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override DecoderFallbackBuffer CreateFallbackBuffer()
		{
			throw null;
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600130A RID: 4874 RVA: 0x00017A6E File Offset: 0x00015C6E
		[global::Cpp2ILInjected.Token(Token = "0x1700020E")]
		public override int MaxCharCount
		{
			[global::Cpp2ILInjected.Token(Token = "0x60014C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CB38E0", Offset = "0x1CB38E0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600130B RID: 4875 RVA: 0x00017A71 File Offset: 0x00015C71
		[global::Cpp2ILInjected.Token(Token = "0x60014C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB38EC", Offset = "0x1CB38EC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object value)
		{
			throw null;
		}

		// Token: 0x0600130C RID: 4876 RVA: 0x00017A74 File Offset: 0x00015C74
		[global::Cpp2ILInjected.Token(Token = "0x60014C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CB3960", Offset = "0x1CB3960", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x0400088C RID: 2188
		[global::Cpp2ILInjected.Token(Token = "0x4000AF8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string _strDefault;
	}
}
