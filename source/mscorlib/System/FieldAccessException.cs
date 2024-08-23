using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x02000080 RID: 128
	[global::Cpp2ILInjected.Token(Token = "0x20000A7")]
	[global::System.Serializable]
	public class FieldAccessException : global::System.MemberAccessException
	{
		// Token: 0x060005E1 RID: 1505 RVA: 0x000156B0 File Offset: 0x000138B0
		[global::Cpp2ILInjected.Token(Token = "0x600067B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1EF78", Offset = "0x1C1EF78", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public FieldAccessException()
		{
			throw null;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x000156B3 File Offset: 0x000138B3
		[global::Cpp2ILInjected.Token(Token = "0x600067C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1EFD4", Offset = "0x1C1EFD4", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.ObjectData.TileObjectData", Member = "WriteCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeFieldInfo), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public FieldAccessException(string message)
		{
			throw null;
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x000156B6 File Offset: 0x000138B6
		[global::Cpp2ILInjected.Token(Token = "0x600067D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C1EFF8", Offset = "0x1C1EFF8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MemberAccessException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected FieldAccessException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
