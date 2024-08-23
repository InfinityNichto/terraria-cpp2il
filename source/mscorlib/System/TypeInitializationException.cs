using System;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x020000E1 RID: 225
	[global::Cpp2ILInjected.Token(Token = "0x2000113")]
	[global::System.Serializable]
	public sealed class TypeInitializationException : global::System.SystemException
	{
		// Token: 0x060009F8 RID: 2552 RVA: 0x000161F0 File Offset: 0x000143F0
		[global::Cpp2ILInjected.Token(Token = "0x6000AA0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C503B8", Offset = "0x1C503B8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private TypeInitializationException()
		{
			throw null;
		}

		// Token: 0x060009F9 RID: 2553 RVA: 0x000161F3 File Offset: 0x000143F3
		[global::Cpp2ILInjected.Token(Token = "0x6000AA1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50410", Offset = "0x1C50410", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.JapaneseCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Globalization.TaiwanCalendar), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public TypeInitializationException(string fullTypeName, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x000161F6 File Offset: 0x000143F6
		[global::Cpp2ILInjected.Token(Token = "0x6000AA2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C50490", Offset = "0x1C50490", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		internal TypeInitializationException(string fullTypeName, string message, global::System.Exception innerException)
		{
			throw null;
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x000161F9 File Offset: 0x000143F9
		[global::Cpp2ILInjected.Token(Token = "0x6000AA3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C504C8", Offset = "0x1C504C8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal TypeInitializationException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x000161FC File Offset: 0x000143FC
		[global::Cpp2ILInjected.Token(Token = "0x6000AA4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5054C", Offset = "0x1C5054C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Exception), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060009FD RID: 2557 RVA: 0x000161FF File Offset: 0x000143FF
		[global::Cpp2ILInjected.Token(Token = "0x170000F1")]
		public string TypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000AA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5064C", Offset = "0x1C5064C", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040002A3 RID: 675
		[global::Cpp2ILInjected.Token(Token = "0x40003F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private string _typeName;
	}
}
