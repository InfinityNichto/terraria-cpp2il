using System;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000426 RID: 1062
	[global::System.CLSCompliant(false)]
	[global::Cpp2ILInjected.Token(Token = "0x20004E5")]
	public sealed class Pointer : global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x0600217C RID: 8572 RVA: 0x0001A294 File Offset: 0x00018494
		[global::Cpp2ILInjected.Token(Token = "0x6002416")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83D4C", Offset = "0x1B83D4C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private unsafe Pointer(void* ptr, global::System.Type ptrType)
		{
			throw null;
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0001A297 File Offset: 0x00018497
		[global::Cpp2ILInjected.Token(Token = "0x6002417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83D78", Offset = "0x1B83D78", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsPointer", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "IsRuntimeImplemented", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public unsafe static object Box(void* ptr, global::System.Type type)
		{
			throw null;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x0001A29A File Offset: 0x0001849A
		[global::Cpp2ILInjected.Token(Token = "0x6002418")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B83EE8", Offset = "0x1B83EE8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.PlatformNotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void System.Runtime.Serialization.ISerializable.GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x040010E6 RID: 4326
		[global::Cpp2ILInjected.Token(Token = "0x4001400")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private unsafe readonly void* _ptr;

		// Token: 0x040010E7 RID: 4327
		[global::Cpp2ILInjected.Token(Token = "0x4001401")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly global::System.Type _ptrType;
	}
}
