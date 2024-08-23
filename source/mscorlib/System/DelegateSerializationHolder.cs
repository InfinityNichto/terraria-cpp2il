using System;
using System.Reflection;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200012C RID: 300
	[global::Cpp2ILInjected.Token(Token = "0x2000171")]
	[global::System.Serializable]
	internal class DelegateSerializationHolder : global::System.Runtime.Serialization.ISerializable, global::System.Runtime.Serialization.IObjectReference
	{
		// Token: 0x06000DFB RID: 3579 RVA: 0x00016CE2 File Offset: 0x00014EE2
		[global::Cpp2ILInjected.Token(Token = "0x6000EE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D4E0", Offset = "0x1C7D4E0", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DelegateSerializationHolder.DelegateEntry), Member = "DeserializeDelegate", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(int)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[] { typeof(global::System.Delegate[]) }, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private DelegateSerializationHolder(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x06000DFC RID: 3580 RVA: 0x00016CE5 File Offset: 0x00014EE5
		[global::Cpp2ILInjected.Token(Token = "0x6000EE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7D118", Offset = "0x1C7D118", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MulticastDelegate), Member = "GetObjectData", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.DelegateSerializationHolder.DelegateEntry), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "SetType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void GetDelegateData(global::System.Delegate instance, global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext ctx)
		{
			throw null;
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00016CE8 File Offset: 0x00014EE8
		[global::Cpp2ILInjected.Token(Token = "0x6000EE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DA18", Offset = "0x1C7DA18", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x00016CEB File Offset: 0x00014EEB
		[global::Cpp2ILInjected.Token(Token = "0x6000EE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C7DA50", Offset = "0x1C7DA50", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public object GetRealObject(global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x040004A1 RID: 1185
		[global::Cpp2ILInjected.Token(Token = "0x4000669")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Delegate _delegate;

		// Token: 0x02000598 RID: 1432
		[global::Cpp2ILInjected.Token(Token = "0x2000172")]
		[global::System.Serializable]
		private class DelegateEntry
		{
			// Token: 0x06003FD3 RID: 16339 RVA: 0x0001FA33 File Offset: 0x0001DC33
			[global::Cpp2ILInjected.Token(Token = "0x6000EE5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7D928", Offset = "0x1C7D928", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DelegateSerializationHolder), Member = "GetDelegateData", MemberParameters = new object[]
			{
				typeof(global::System.Delegate),
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public DelegateEntry(global::System.Delegate del, string targetLabel)
			{
				throw null;
			}

			// Token: 0x06003FD4 RID: 16340 RVA: 0x0001FA36 File Offset: 0x0001DC36
			[global::Cpp2ILInjected.Token(Token = "0x6000EE6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C7D6BC", Offset = "0x1C7D6BC", Length = "0x26C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DelegateSerializationHolder), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(global::System.Runtime.Serialization.SerializationInfo),
				typeof(global::System.Runtime.Serialization.StreamingContext)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValueNoThrow", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Type)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.Assembly), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(global::System.Reflection.Assembly))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodInfo),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object),
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MethodInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Reflection.MethodInfo),
				typeof(global::System.Reflection.MethodInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(object),
				typeof(global::System.Reflection.MethodInfo),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "CreateDelegate", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type),
				typeof(string),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(global::System.Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public global::System.Delegate DeserializeDelegate(global::System.Runtime.Serialization.SerializationInfo info, int index)
			{
				throw null;
			}

			// Token: 0x0400186F RID: 6255
			[global::Cpp2ILInjected.Token(Token = "0x400066A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string type;

			// Token: 0x04001870 RID: 6256
			[global::Cpp2ILInjected.Token(Token = "0x400066B")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private string assembly;

			// Token: 0x04001871 RID: 6257
			[global::Cpp2ILInjected.Token(Token = "0x400066C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private object target;

			// Token: 0x04001872 RID: 6258
			[global::Cpp2ILInjected.Token(Token = "0x400066D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private string targetTypeAssembly;

			// Token: 0x04001873 RID: 6259
			[global::Cpp2ILInjected.Token(Token = "0x400066E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private string targetTypeName;

			// Token: 0x04001874 RID: 6260
			[global::Cpp2ILInjected.Token(Token = "0x400066F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private string methodName;

			// Token: 0x04001875 RID: 6261
			[global::Cpp2ILInjected.Token(Token = "0x4000670")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
			public global::System.DelegateSerializationHolder.DelegateEntry delegateEntry;
		}
	}
}
