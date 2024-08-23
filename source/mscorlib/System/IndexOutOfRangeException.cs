using System;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono;

namespace System
{
	// Token: 0x0200009D RID: 157
	[global::Cpp2ILInjected.Token(Token = "0x20000CD")]
	[global::System.Serializable]
	public sealed class IndexOutOfRangeException : global::System.SystemException
	{
		// Token: 0x060006CC RID: 1740 RVA: 0x00015908 File Offset: 0x00013B08
		[global::Cpp2ILInjected.Token(Token = "0x6000771")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C308E4", Offset = "0x1C308E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "RefreshStrip", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(ref int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.TileObjectPreviewData", Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.DataStructures.TileObjectPreviewData", Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::Mono.RuntimeGPtrArrayHandle), Member = "Lookup", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(string), Member = "FillStringChecked", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.ThrowHelper), Member = "CreateIndexOutOfRangeException", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "MakeArrayType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Text.StringBuilder), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.SignatureType), Member = "MakeArrayType", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketAddress", Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.SocketAddress", Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EventDescriptorCollection", Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "System.ComponentModel.EventDescriptor")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EventDescriptorCollection", Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptorCollection", Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "System.ComponentModel.PropertyDescriptor")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptorCollection", Member = "System.Collections.IDictionary.set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptorCollection", Member = "System.Collections.IList.set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Collections.IndexedSet`1", Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 17)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public IndexOutOfRangeException()
		{
			throw null;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0001590B File Offset: 0x00013B0B
		[global::Cpp2ILInjected.Token(Token = "0x6000772")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30940", Offset = "0x1C30940", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public IndexOutOfRangeException(string message)
		{
			throw null;
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0001590E File Offset: 0x00013B0E
		[global::Cpp2ILInjected.Token(Token = "0x6000773")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C30964", Offset = "0x1C30964", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		internal IndexOutOfRangeException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
