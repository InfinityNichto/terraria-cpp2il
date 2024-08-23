using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000CC RID: 204
	[global::Cpp2ILInjected.Token(Token = "0x20000FE")]
	[global::System.Serializable]
	public sealed class CultureAwareComparer : global::System.StringComparer, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x060008E0 RID: 2272 RVA: 0x00015F08 File Offset: 0x00014108
		[global::Cpp2ILInjected.Token(Token = "0x6000988")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AA1C", Offset = "0x1C4AA1C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.CultureAwareComparer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CompareInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		internal CultureAwareComparer(global::System.Globalization.CultureInfo culture, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

		// Token: 0x060008E1 RID: 2273 RVA: 0x00015F0B File Offset: 0x0001410B
		[global::Cpp2ILInjected.Token(Token = "0x6000989")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AA68", Offset = "0x1C4AA68", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.StringComparer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.CultureAwareComparer), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal CultureAwareComparer(global::System.Globalization.CompareInfo compareInfo, global::System.Globalization.CompareOptions options)
		{
			throw null;
		}

		// Token: 0x060008E2 RID: 2274 RVA: 0x00015F0E File Offset: 0x0001410E
		[global::Cpp2ILInjected.Token(Token = "0x600098A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AB48", Offset = "0x1C4AB48", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetBoolean", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private CultureAwareComparer(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060008E3 RID: 2275 RVA: 0x00015F11 File Offset: 0x00014111
		[global::Cpp2ILInjected.Token(Token = "0x600098B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AD50", Offset = "0x1C4AD50", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int Compare(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008E4 RID: 2276 RVA: 0x00015F14 File Offset: 0x00014114
		[global::Cpp2ILInjected.Token(Token = "0x600098C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AD90", Offset = "0x1C4AD90", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Equals(string x, string y)
		{
			throw null;
		}

		// Token: 0x060008E5 RID: 2277 RVA: 0x00015F17 File Offset: 0x00014117
		[global::Cpp2ILInjected.Token(Token = "0x600098D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4ADD8", Offset = "0x1C4ADD8", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CompareInfo), Member = "GetHashCodeOfString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Globalization.CompareOptions)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int GetHashCode(string obj)
		{
			throw null;
		}

		// Token: 0x060008E6 RID: 2278 RVA: 0x00015F1A File Offset: 0x0001411A
		[global::Cpp2ILInjected.Token(Token = "0x600098E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AE40", Offset = "0x1C4AE40", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060008E7 RID: 2279 RVA: 0x00015F1D File Offset: 0x0001411D
		[global::Cpp2ILInjected.Token(Token = "0x600098F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AECC", Offset = "0x1C4AECC", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060008E8 RID: 2280 RVA: 0x00015F20 File Offset: 0x00014120
		[global::Cpp2ILInjected.Token(Token = "0x6000990")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4AEF8", Offset = "0x1C4AEF8", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x04000254 RID: 596
		[global::Cpp2ILInjected.Token(Token = "0x40003A6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly global::System.Globalization.CompareInfo _compareInfo;

		// Token: 0x04000255 RID: 597
		[global::Cpp2ILInjected.Token(Token = "0x40003A7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Globalization.CompareOptions _options;
	}
}
