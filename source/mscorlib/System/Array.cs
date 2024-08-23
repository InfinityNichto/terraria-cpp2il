using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Security.Cryptography;

namespace System
{
	// Token: 0x02000102 RID: 258
	[global::Cpp2ILInjected.Token(Token = "0x2000134")]
	[global::System.Serializable]
	public abstract class Array : global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.IList, global::System.Collections.IStructuralComparable, global::System.Collections.IStructuralEquatable, global::System.ICloneable
	{
		// Token: 0x06000B3F RID: 2879 RVA: 0x000165B0 File Offset: 0x000147B0
		[global::Cpp2ILInjected.Token(Token = "0x6000BE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56D6C", Offset = "0x1C56D6C", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static global::System.Array CreateInstance(global::System.Type elementType, params long[] lengths)
		{
			throw null;
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000165B3 File Offset: 0x000147B3
		[global::Cpp2ILInjected.Token(Token = "0x6000BE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7044", Offset = "0x14D7044", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.CustomAttributeData), Member = "ResolveArguments", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static global::System.Collections.ObjectModel.ReadOnlyCollection<T> AsReadOnly<T>(T[] array)
		{
			throw null;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000165B6 File Offset: 0x000147B6
		[global::Cpp2ILInjected.Token(Token = "0x6000BE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1562E00", Offset = "0x1562E00", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "InitialiseTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void Resize<T>(ref T[] array, int newSize)
		{
			throw null;
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x000165B9 File Offset: 0x000147B9
		[global::Cpp2ILInjected.Token(Token = "0x17000108")]
		private int System.Collections.ICollection.Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BEA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5713C", Offset = "0x1C5713C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000B43 RID: 2883 RVA: 0x000165BC File Offset: 0x000147BC
		[global::Cpp2ILInjected.Token(Token = "0x17000109")]
		private bool System.Collections.IList.IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BEB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C57140", Offset = "0x1C57140", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000B44 RID: 2884 RVA: 0x000165BF File Offset: 0x000147BF
		// (set) Token: 0x06000B45 RID: 2885 RVA: 0x000165C2 File Offset: 0x000147C2
		[global::Cpp2ILInjected.Token(Token = "0x1700010A")]
		private object System.Collections.IList.Item
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000BEC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C57148", Offset = "0x1C57148", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000BED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5714C", Offset = "0x1C5714C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x000165C5 File Offset: 0x000147C5
		[global::Cpp2ILInjected.Token(Token = "0x6000BEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C572C0", Offset = "0x1C572C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private int System.Collections.IList.Add(object value)
		{
			throw null;
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x000165C8 File Offset: 0x000147C8
		[global::Cpp2ILInjected.Token(Token = "0x6000BEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5730C", Offset = "0x1C5730C", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object)
		}, ReturnType = typeof(int))]
		private bool System.Collections.IList.Contains(object value)
		{
			throw null;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000165CB File Offset: 0x000147CB
		[global::Cpp2ILInjected.Token(Token = "0x6000BF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C573B0", Offset = "0x1C573B0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.Collections.IList.Clear()
		{
			throw null;
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x000165CE File Offset: 0x000147CE
		[global::Cpp2ILInjected.Token(Token = "0x6000BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57504", Offset = "0x1C57504", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object)
		}, ReturnType = typeof(int))]
		private int System.Collections.IList.IndexOf(object value)
		{
			throw null;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000165D1 File Offset: 0x000147D1
		[global::Cpp2ILInjected.Token(Token = "0x6000BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57508", Offset = "0x1C57508", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Insert(int index, object value)
		{
			throw null;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x000165D4 File Offset: 0x000147D4
		[global::Cpp2ILInjected.Token(Token = "0x6000BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57554", Offset = "0x1C57554", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.Remove(object value)
		{
			throw null;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x000165D7 File Offset: 0x000147D7
		[global::Cpp2ILInjected.Token(Token = "0x6000BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C575A0", Offset = "0x1C575A0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void System.Collections.IList.RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x000165DA File Offset: 0x000147DA
		[global::Cpp2ILInjected.Token(Token = "0x6000BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C575EC", Offset = "0x1C575EC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Modules.TileObjectBaseModule", Member = ".ctor", MemberParameters = new object[] { "Terraria.Modules.TileObjectBaseModule" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Remoting.Messaging.CADMessageBase), Member = "UnmarshalArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Collections.ArrayList)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.SizedArray), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.SizedArray) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.IntSizedArray), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.IntSizedArray) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimePropertyInfo), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object[]),
			typeof(global::System.Globalization.CultureInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ArrayList), Member = "InsertRange", MemberParameters = new object[]
		{
			typeof(int),
			typeof(global::System.Collections.ICollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Concurrent.ConcurrentQueue<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Net.Security.BufferOffsetSize2", Member = "MakeRoom", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Mime.WriteStateInfoBase", Member = "EnsureSpaceInBuffer", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.Mime.WriteStateInfoBase", Member = "Append", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider.ReflectedTypeData", Member = "GetEditor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetAttributes", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReflectTypeDescriptionProvider", Member = "ReflectGetAttributes", MemberParameters = new object[] { typeof(global::System.Reflection.MemberInfo) }, ReturnType = "System.Attribute[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2_Session", MemberParameters = new object[]
		{
			typeof(string),
			"System.Byte[]",
			"System.Byte[]&",
			"System.Byte[]&"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Protocol.Ntlm.ChallengeResponse2", Member = "Compute_NTLMv2", MemberParameters = new object[]
		{
			"Mono.Security.Protocol.Ntlm.Type2Message",
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Interface.MonoTlsSettings", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.Interface.MonoTlsSettings" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 27)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void CopyTo(global::System.Array array, int index)
		{
			throw null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000165DD File Offset: 0x000147DD
		[global::Cpp2ILInjected.Token(Token = "0x6000BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57B94", Offset = "0x1C57B94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 117)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
		public object Clone()
		{
			throw null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000165E0 File Offset: 0x000147E0
		[global::Cpp2ILInjected.Token(Token = "0x6000BF7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57B9C", Offset = "0x1C57B9C", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private int System.Collections.IStructuralComparable.CompareTo(object other, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x000165E3 File Offset: 0x000147E3
		[global::Cpp2ILInjected.Token(Token = "0x6000BF8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57D74", Offset = "0x1C57D74", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private bool System.Collections.IStructuralEquatable.Equals(object other, global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x000165E6 File Offset: 0x000147E6
		[global::Cpp2ILInjected.Token(Token = "0x6000BF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57EF8", Offset = "0x1C57EF8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static int CombineHashCodes(int h1, int h2)
		{
			throw null;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x000165E9 File Offset: 0x000147E9
		[global::Cpp2ILInjected.Token(Token = "0x6000BFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57F04", Offset = "0x1C57F04", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int System.Collections.IStructuralEquatable.GetHashCode(global::System.Collections.IEqualityComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x000165EC File Offset: 0x000147EC
		[global::Cpp2ILInjected.Token(Token = "0x6000BFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58074", Offset = "0x1C58074", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int BinarySearch(global::System.Array array, object value)
		{
			throw null;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x000165EF File Offset: 0x000147EF
		[global::Cpp2ILInjected.Token(Token = "0x6000BFC")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D78B0", Offset = "0x14D78B0", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static TOutput[] ConvertAll<TInput, TOutput>(TInput[] array, global::System.Converter<TInput, TOutput> converter)
		{
			throw null;
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x000165F2 File Offset: 0x000147F2
		[global::Cpp2ILInjected.Token(Token = "0x6000BFD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5856C", Offset = "0x1C5856C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Copy(global::System.Array sourceArray, global::System.Array destinationArray, long length)
		{
			throw null;
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x000165F5 File Offset: 0x000147F5
		[global::Cpp2ILInjected.Token(Token = "0x6000BFE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C586A0", Offset = "0x1C586A0", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void Copy(global::System.Array sourceArray, long sourceIndex, global::System.Array destinationArray, long destinationIndex, long length)
		{
			throw null;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x000165F8 File Offset: 0x000147F8
		[global::Cpp2ILInjected.Token(Token = "0x6000BFF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58768", Offset = "0x1C58768", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void CopyTo(global::System.Array array, long index)
		{
			throw null;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x000165FB File Offset: 0x000147FB
		[global::Cpp2ILInjected.Token(Token = "0x6000C00")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D8848", Offset = "0x14D8848", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void ForEach<T>(T[] array, global::System.Action<T> action)
		{
			throw null;
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x000165FE File Offset: 0x000147FE
		[global::Cpp2ILInjected.Token(Token = "0x1700010B")]
		public long LongLength
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C01")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C587D8", Offset = "0x1C587D8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00016601 File Offset: 0x00014801
		[global::Cpp2ILInjected.Token(Token = "0x6000C02")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58840", Offset = "0x1C58840", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public long GetLongLength(int dimension)
		{
			throw null;
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00016604 File Offset: 0x00014804
		[global::Cpp2ILInjected.Token(Token = "0x6000C03")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58854", Offset = "0x1C58854", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public object GetValue(long index)
		{
			throw null;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00016607 File Offset: 0x00014807
		[global::Cpp2ILInjected.Token(Token = "0x6000C04")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C588C4", Offset = "0x1C588C4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public object GetValue(long index1, long index2)
		{
			throw null;
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x0001660A File Offset: 0x0001480A
		[global::Cpp2ILInjected.Token(Token = "0x6000C05")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C589CC", Offset = "0x1C589CC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public object GetValue(long index1, long index2, long index3)
		{
			throw null;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x0001660D File Offset: 0x0001480D
		[global::Cpp2ILInjected.Token(Token = "0x6000C06")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58B0C", Offset = "0x1C58B0C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public object GetValue(params long[] indices)
		{
			throw null;
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000B5F RID: 2911 RVA: 0x00016610 File Offset: 0x00014810
		[global::Cpp2ILInjected.Token(Token = "0x1700010C")]
		public bool IsFixedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C07")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C58C78", Offset = "0x1C58C78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x00016613 File Offset: 0x00014813
		[global::Cpp2ILInjected.Token(Token = "0x1700010D")]
		public bool IsReadOnly
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C08")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C58C80", Offset = "0x1C58C80", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x06000B61 RID: 2913 RVA: 0x00016616 File Offset: 0x00014816
		[global::Cpp2ILInjected.Token(Token = "0x1700010E")]
		public bool IsSynchronized
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C09")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C58C88", Offset = "0x1C58C88", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x06000B62 RID: 2914 RVA: 0x00016619 File Offset: 0x00014819
		[global::Cpp2ILInjected.Token(Token = "0x1700010F")]
		public object SyncRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C0A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C58C90", Offset = "0x1C58C90", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0001661C File Offset: 0x0001481C
		[global::Cpp2ILInjected.Token(Token = "0x6000C0B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58C94", Offset = "0x1C58C94", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(object),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(int))]
		public static int BinarySearch(global::System.Array array, int index, int length, object value)
		{
			throw null;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0001661F File Offset: 0x0001481F
		[global::Cpp2ILInjected.Token(Token = "0x6000C0C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58C9C", Offset = "0x1C58C9C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.DatatypeImplementation", Member = "FromTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = "System.Xml.Schema.DatatypeImplementation")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(object),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int BinarySearch(global::System.Array array, object value, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00016622 File Offset: 0x00014822
		[global::Cpp2ILInjected.Token(Token = "0x6000C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58104", Offset = "0x1C58104", Length = "0x468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "BinarySearch", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.SortedList.KeyList", Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.SortedList), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.SortedList), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.SortedList), Member = "IndexOfKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 43)]
		public static int BinarySearch(global::System.Array array, int index, int length, object value, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00016625 File Offset: 0x00014825
		[global::Cpp2ILInjected.Token(Token = "0x6000C0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58D38", Offset = "0x1C58D38", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static int GetMedian(int low, int hi)
		{
			throw null;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x00016628 File Offset: 0x00014828
		[global::Cpp2ILInjected.Token(Token = "0x6000C0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7218", Offset = "0x14D7218", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebUtility.HtmlEntities", Member = "Lookup", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int BinarySearch<T>(T[] array, T value)
		{
			throw null;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0001662B File Offset: 0x0001482B
		[global::Cpp2ILInjected.Token(Token = "0x6000C10")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7374", Offset = "0x14D7374", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "AddDefaultAttributeDtd", MemberParameters = new object[]
		{
			"System.Xml.IDtdDefaultAttributeInfo",
			typeof(bool),
			"NodeData[]"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int BinarySearch<T>(T[] array, T value, global::System.Collections.Generic.IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0001662E File Offset: 0x0001482E
		[global::Cpp2ILInjected.Token(Token = "0x6000C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D73EC", Offset = "0x14D73EC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static int BinarySearch<T>(T[] array, int index, int length, T value)
		{
			throw null;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x00016631 File Offset: 0x00014831
		[global::Cpp2ILInjected.Token(Token = "0x6000C12")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7400", Offset = "0x14D7400", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static int BinarySearch<T>(T[] array, int index, int length, T value, global::System.Collections.Generic.IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x00016634 File Offset: 0x00014834
		[global::Cpp2ILInjected.Token(Token = "0x6000C13")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C57324", Offset = "0x1C57324", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "System.Collections.IList.Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "System.Collections.IList.IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int IndexOf(global::System.Array array, object value)
		{
			throw null;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x00016637 File Offset: 0x00014837
		[global::Cpp2ILInjected.Token(Token = "0x6000C14")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58FB4", Offset = "0x1C58FB4", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int IndexOf(global::System.Array array, object value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0001663A File Offset: 0x0001483A
		[global::Cpp2ILInjected.Token(Token = "0x6000C15")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58D44", Offset = "0x1C58D44", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ArrayList), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public static int IndexOf(global::System.Array array, object value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0001663D File Offset: 0x0001483D
		[global::Cpp2ILInjected.Token(Token = "0x6000C16")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D891C", Offset = "0x14D891C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.NetworkInformation.CommonUnixIPGlobalProperties", Member = "get_DomainName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int IndexOf<T>(T[] array, T value)
		{
			throw null;
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x00016640 File Offset: 0x00014840
		[global::Cpp2ILInjected.Token(Token = "0x6000C17")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D8B38", Offset = "0x14D8B38", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int IndexOf<T>(T[] array, T value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x00016643 File Offset: 0x00014843
		[global::Cpp2ILInjected.Token(Token = "0x6000C18")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D8BA4", Offset = "0x14D8BA4", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static int IndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x00016646 File Offset: 0x00014846
		[global::Cpp2ILInjected.Token(Token = "0x6000C19")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59050", Offset = "0x1C59050", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int LastIndexOf(global::System.Array array, object value)
		{
			throw null;
		}

		// Token: 0x06000B72 RID: 2930 RVA: 0x00016649 File Offset: 0x00014849
		[global::Cpp2ILInjected.Token(Token = "0x6000C1A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59354", Offset = "0x1C59354", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static int LastIndexOf(global::System.Array array, object value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000B73 RID: 2931 RVA: 0x0001664C File Offset: 0x0001484C
		[global::Cpp2ILInjected.Token(Token = "0x6000C1B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C590D8", Offset = "0x1C590D8", Length = "0x27C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "LastIndexOf", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public static int LastIndexOf(global::System.Array array, object value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000B74 RID: 2932 RVA: 0x0001664F File Offset: 0x0001484F
		[global::Cpp2ILInjected.Token(Token = "0x6000C1C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1562BA4", Offset = "0x1562BA4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MulticastDelegate), Member = "RemoveImpl", MemberParameters = new object[] { typeof(global::System.Delegate) }, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int LastIndexOf<T>(T[] array, T value)
		{
			throw null;
		}

		// Token: 0x06000B75 RID: 2933 RVA: 0x00016652 File Offset: 0x00014852
		[global::Cpp2ILInjected.Token(Token = "0x6000C1D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1562C10", Offset = "0x1562C10", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int LastIndexOf<T>(T[] array, T value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000B76 RID: 2934 RVA: 0x00016655 File Offset: 0x00014855
		[global::Cpp2ILInjected.Token(Token = "0x6000C1E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1562C80", Offset = "0x1562C80", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static int LastIndexOf<T>(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000B77 RID: 2935 RVA: 0x00016658 File Offset: 0x00014858
		[global::Cpp2ILInjected.Token(Token = "0x6000C1F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C593AC", Offset = "0x1C593AC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Reverse(global::System.Array array)
		{
			throw null;
		}

		// Token: 0x06000B78 RID: 2936 RVA: 0x0001665B File Offset: 0x0001485B
		[global::Cpp2ILInjected.Token(Token = "0x6000C20")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59430", Offset = "0x1C59430", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Stack<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array[]), Member = "Reverse", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public static void Reverse(global::System.Array array, int index, int length)
		{
			throw null;
		}

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001665E File Offset: 0x0001485E
		[global::Cpp2ILInjected.Token(Token = "0x6000C21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1563A30", Offset = "0x1563A30", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "GetParametersFromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPrivateKeyBlobDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(global::System.Security.Cryptography.DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "ToCapiPrivateKeyBlob", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "GetParametersFromCapiPublicKeyBlob", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "FromCapiPublicKeyBlobDSA", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(global::System.Security.Cryptography.DSA))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mono.Security.Cryptography.CryptoConvert), Member = "ToCapiPublicKeyBlob", MemberParameters = new object[] { typeof(global::System.Security.Cryptography.DSA) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "GetSerialNumber", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Cryptography.X509Certificates.X509Certificate), Member = "ToString", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Security.Cryptography.DerSequenceReader", Member = "ReadInteger", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.ASN1Convert", Member = "FromInt32", MemberParameters = new object[] { typeof(int) }, ReturnType = "Mono.Security.ASN1")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.X509.X509Crl.X509CrlEntry", Member = ".ctor", MemberParameters = new object[] { "Mono.Security.ASN1" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Cryptography.CryptoConvert", Member = "GetParametersFromCapiPrivateKeyBlob", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(global::System.Security.Cryptography.RSAParameters))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 42)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Reverse<T>(T[] array)
		{
			throw null;
		}

		// Token: 0x06000B7A RID: 2938 RVA: 0x00016661 File Offset: 0x00014861
		[global::Cpp2ILInjected.Token(Token = "0x6000C22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1563B08", Offset = "0x1563B08", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void Reverse<T>(T[] array, int index, int length)
		{
			throw null;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x00016664 File Offset: 0x00014864
		[global::Cpp2ILInjected.Token(Token = "0x6000C23")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59674", Offset = "0x1C59674", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void SetValue(object value, long index)
		{
			throw null;
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00016667 File Offset: 0x00014867
		[global::Cpp2ILInjected.Token(Token = "0x6000C24")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C596E4", Offset = "0x1C596E4", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void SetValue(object value, long index1, long index2)
		{
			throw null;
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0001666A File Offset: 0x0001486A
		[global::Cpp2ILInjected.Token(Token = "0x6000C25")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C597FC", Offset = "0x1C597FC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void SetValue(object value, long index1, long index2, long index3)
		{
			throw null;
		}

		// Token: 0x06000B7E RID: 2942 RVA: 0x0001666D File Offset: 0x0001486D
		[global::Cpp2ILInjected.Token(Token = "0x6000C26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59944", Offset = "0x1C59944", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void SetValue(object value, params long[] indices)
		{
			throw null;
		}

		// Token: 0x06000B7F RID: 2943 RVA: 0x00016670 File Offset: 0x00014870
		[global::Cpp2ILInjected.Token(Token = "0x6000C27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59AC0", Offset = "0x1C59AC0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort(global::System.Array array)
		{
			throw null;
		}

		// Token: 0x06000B80 RID: 2944 RVA: 0x00016673 File Offset: 0x00014873
		[global::Cpp2ILInjected.Token(Token = "0x6000C28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59D88", Offset = "0x1C59D88", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		public static void Sort(global::System.Array array, int index, int length)
		{
			throw null;
		}

		// Token: 0x06000B81 RID: 2945 RVA: 0x00016676 File Offset: 0x00014876
		[global::Cpp2ILInjected.Token(Token = "0x6000C29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59D9C", Offset = "0x1C59D9C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.CultureInfoConverter", Member = "GetStandardValues", MemberParameters = new object[] { "System.ComponentModel.ITypeDescriptorContext" }, ReturnType = "System.ComponentModel.TypeConverter.StandardValuesCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EventDescriptorCollection", Member = "InternalSort", MemberParameters = new object[] { typeof(global::System.Collections.IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptorCollection", Member = "InternalSort", MemberParameters = new object[] { typeof(global::System.Collections.IComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort(global::System.Array array, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B82 RID: 2946 RVA: 0x00016679 File Offset: 0x00014879
		[global::Cpp2ILInjected.Token(Token = "0x6000C2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59E2C", Offset = "0x1C59E2C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.ArrayList.IListWrapper", Member = "Sort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ArrayList), Member = "Sort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.ReferenceConverter", Member = "GetStandardValues", MemberParameters = new object[] { "System.ComponentModel.ITypeDescriptorContext" }, ReturnType = "System.ComponentModel.TypeConverter.StandardValuesCollection")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		public static void Sort(global::System.Array array, int index, int length, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B83 RID: 2947 RVA: 0x0001667C File Offset: 0x0001487C
		[global::Cpp2ILInjected.Token(Token = "0x6000C2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59E40", Offset = "0x1C59E40", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort(global::System.Array keys, global::System.Array items)
		{
			throw null;
		}

		// Token: 0x06000B84 RID: 2948 RVA: 0x0001667F File Offset: 0x0001487F
		[global::Cpp2ILInjected.Token(Token = "0x6000C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59ED0", Offset = "0x1C59ED0", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort(global::System.Array keys, global::System.Array items, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B85 RID: 2949 RVA: 0x00016682 File Offset: 0x00014882
		[global::Cpp2ILInjected.Token(Token = "0x6000C2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59F6C", Offset = "0x1C59F6C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		public static void Sort(global::System.Array keys, global::System.Array items, int index, int length)
		{
			throw null;
		}

		// Token: 0x06000B86 RID: 2950 RVA: 0x00016685 File Offset: 0x00014885
		[global::Cpp2ILInjected.Token(Token = "0x6000C2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59B4C", Offset = "0x1C59B4C", Length = "0x23C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SortImpl", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static void Sort(global::System.Array keys, global::System.Array items, int index, int length, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000B87 RID: 2951 RVA: 0x00016688 File Offset: 0x00014888
		[global::Cpp2ILInjected.Token(Token = "0x6000C2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1569ADC", Offset = "0x1569ADC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort<T>(T[] array)
		{
			throw null;
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0001668B File Offset: 0x0001488B
		[global::Cpp2ILInjected.Token(Token = "0x6000C30")]
		[global::Cpp2ILInjected.Address(RVA = "0x156A098", Offset = "0x156A098", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlTextReaderImpl", Member = "AttributeDuplCheck", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Sort<T>(T[] array, int index, int length)
		{
			throw null;
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0001668E File Offset: 0x0001488E
		[global::Cpp2ILInjected.Token(Token = "0x6000C31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1569B4C", Offset = "0x1569B4C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Text.RegularExpressions.RegexParser", Member = "AssignNameSlots", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort<T>(T[] array, global::System.Collections.Generic.IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x00016691 File Offset: 0x00014891
		[global::Cpp2ILInjected.Token(Token = "0x6000C32")]
		[global::Cpp2ILInjected.Address(RVA = "0x156A18C", Offset = "0x156A18C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public static void Sort<T>(T[] array, int index, int length, global::System.Collections.Generic.IComparer<T> comparer)
		{
			throw null;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x00016694 File Offset: 0x00014894
		[global::Cpp2ILInjected.Token(Token = "0x6000C33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1569BBC", Offset = "0x1569BBC", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void Sort<T>(T[] array, global::System.Comparison<T> comparison)
		{
			throw null;
		}

		// Token: 0x06000B8C RID: 2956 RVA: 0x00016697 File Offset: 0x00014897
		[global::Cpp2ILInjected.Token(Token = "0x6000C34")]
		[global::Cpp2ILInjected.Address(RVA = "0x156A028", Offset = "0x156A028", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items)
		{
			throw null;
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0001669A File Offset: 0x0001489A
		[global::Cpp2ILInjected.Token(Token = "0x6000C35")]
		[global::Cpp2ILInjected.Address(RVA = "0x15712B4", Offset = "0x15712B4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length)
		{
			throw null;
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0001669D File Offset: 0x0001489D
		[global::Cpp2ILInjected.Token(Token = "0x6000C36")]
		[global::Cpp2ILInjected.Address(RVA = "0x156A0AC", Offset = "0x156A0AC", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, global::System.Collections.Generic.IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x000166A0 File Offset: 0x000148A0
		[global::Cpp2ILInjected.Token(Token = "0x6000C37")]
		[global::Cpp2ILInjected.Address(RVA = "0x15712C8", Offset = "0x15712C8", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public static void Sort<TKey, TValue>(TKey[] keys, TValue[] items, int index, int length, global::System.Collections.Generic.IComparer<TKey> comparer)
		{
			throw null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x000166A3 File Offset: 0x000148A3
		[global::Cpp2ILInjected.Token(Token = "0x6000C38")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7E2C", Offset = "0x14D7E2C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool Exists<T>(T[] array, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x000166A6 File Offset: 0x000148A6
		[global::Cpp2ILInjected.Token(Token = "0x6000C39")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7E50", Offset = "0x14D7E50", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Fill<T>(T[] array, T value)
		{
			throw null;
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x000166A9 File Offset: 0x000148A9
		[global::Cpp2ILInjected.Token(Token = "0x6000C3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7ED0", Offset = "0x14D7ED0", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void Fill<T>(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000166AC File Offset: 0x000148AC
		[global::Cpp2ILInjected.Token(Token = "0x6000C3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D7FF0", Offset = "0x14D7FF0", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static T Find<T>(T[] array, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000166AF File Offset: 0x000148AF
		[global::Cpp2ILInjected.Token(Token = "0x6000C3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D80D8", Offset = "0x14D80D8", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "GetLanguageFilesForCulture", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = "System.String[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static T[] FindAll<T>(T[] array, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000166B2 File Offset: 0x000148B2
		[global::Cpp2ILInjected.Token(Token = "0x6000C3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D82B0", Offset = "0x14D82B0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int FindIndex<T>(T[] array, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000166B5 File Offset: 0x000148B5
		[global::Cpp2ILInjected.Token(Token = "0x6000C3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D8320", Offset = "0x14D8320", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int FindIndex<T>(T[] array, int startIndex, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000166B8 File Offset: 0x000148B8
		[global::Cpp2ILInjected.Token(Token = "0x6000C3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D8394", Offset = "0x14D8394", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static int FindIndex<T>(T[] array, int startIndex, int count, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000166BB File Offset: 0x000148BB
		[global::Cpp2ILInjected.Token(Token = "0x6000C40")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D8514", Offset = "0x14D8514", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static T FindLast<T>(T[] array, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000166BE File Offset: 0x000148BE
		[global::Cpp2ILInjected.Token(Token = "0x6000C41")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D85F0", Offset = "0x14D85F0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int FindLastIndex<T>(T[] array, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000166C1 File Offset: 0x000148C1
		[global::Cpp2ILInjected.Token(Token = "0x6000C42")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D8660", Offset = "0x14D8660", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static int FindLastIndex<T>(T[] array, int startIndex, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000166C4 File Offset: 0x000148C4
		[global::Cpp2ILInjected.Token(Token = "0x6000C43")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D86D0", Offset = "0x14D86D0", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static int FindLastIndex<T>(T[] array, int startIndex, int count, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000166C7 File Offset: 0x000148C7
		[global::Cpp2ILInjected.Token(Token = "0x6000C44")]
		[global::Cpp2ILInjected.Address(RVA = "0x15716A8", Offset = "0x15716A8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool TrueForAll<T>(T[] array, global::System.Predicate<T> match)
		{
			throw null;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000166CA File Offset: 0x000148CA
		[global::Cpp2ILInjected.Token(Token = "0x6000C45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A064", Offset = "0x1C5A064", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetProgressNumberOfTimesKilledAllBosses", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetNormlBossCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetHardBossCount", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetNumberOfTimesKilledAllBosses", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "PersistentUserData", Member = "GetNumberOfRequiredSlimesKilled", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.EffectParameterCollection", Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.EffectPassCollection", Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.EffectTechniqueCollection", Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "get_ConnectList", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.WebPermission", Member = "get_AcceptList", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.AttributeCollection", Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.EventDescriptorCollection", Member = "GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.ComponentModel.PropertyDescriptorCollection", Member = "GetEnumerator", ReturnType = typeof(global::System.Collections.IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000166CD File Offset: 0x000148CD
		[global::Cpp2ILInjected.Token(Token = "0x6000C46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A110", Offset = "0x1C5A110", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private Array()
		{
			throw null;
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000166D0 File Offset: 0x000148D0
		[global::Cpp2ILInjected.Token(Token = "0x6000C47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A118", Offset = "0x1C5A118", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		internal int InternalArray__ICollection_get_Count()
		{
			throw null;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000166D3 File Offset: 0x000148D3
		[global::Cpp2ILInjected.Token(Token = "0x6000C48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A11C", Offset = "0x1C5A11C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal bool InternalArray__ICollection_get_IsReadOnly()
		{
			throw null;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000166D6 File Offset: 0x000148D6
		[global::Cpp2ILInjected.Token(Token = "0x6000C49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A124", Offset = "0x1C5A124", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		internal ref byte GetRawSzArrayData()
		{
			throw null;
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000166D9 File Offset: 0x000148D9
		[global::Cpp2ILInjected.Token(Token = "0x6000C4A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1509154", Offset = "0x1509154", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.InternalEnumerator<>), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Array) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal global::System.Collections.Generic.IEnumerator<T> InternalArray__IEnumerable_GetEnumerator<T>()
		{
			throw null;
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000166DC File Offset: 0x000148DC
		[global::Cpp2ILInjected.Token(Token = "0x6000C4B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A12C", Offset = "0x1C5A12C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void InternalArray__ICollection_Clear()
		{
			throw null;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000166DF File Offset: 0x000148DF
		[global::Cpp2ILInjected.Token(Token = "0x6000C4C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14DEF18", Offset = "0x14DEF18", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void InternalArray__ICollection_Add<T>(T item)
		{
			throw null;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000166E2 File Offset: 0x000148E2
		[global::Cpp2ILInjected.Token(Token = "0x6000C4D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1503C6C", Offset = "0x1503C6C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal bool InternalArray__ICollection_Remove<T>(T item)
		{
			throw null;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000166E5 File Offset: 0x000148E5
		[global::Cpp2ILInjected.Token(Token = "0x6000C4E")]
		[global::Cpp2ILInjected.Address(RVA = "0x14E4400", Offset = "0x14E4400", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySegment<>), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal bool InternalArray__ICollection_Contains<T>(T item)
		{
			throw null;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000166E8 File Offset: 0x000148E8
		[global::Cpp2ILInjected.Token(Token = "0x6000C4F")]
		[global::Cpp2ILInjected.Address(RVA = "0x14FD5A4", Offset = "0x14FD5A4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		internal void InternalArray__ICollection_CopyTo<T>(T[] array, int arrayIndex)
		{
			throw null;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000166EB File Offset: 0x000148EB
		[global::Cpp2ILInjected.Token(Token = "0x6000C50")]
		[global::Cpp2ILInjected.Address(RVA = "0x151517C", Offset = "0x151517C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal T InternalArray__IReadOnlyList_get_Item<T>(int index)
		{
			throw null;
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000166EE File Offset: 0x000148EE
		[global::Cpp2ILInjected.Token(Token = "0x6000C51")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A178", Offset = "0x1C5A178", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		internal int InternalArray__IReadOnlyCollection_get_Count()
		{
			throw null;
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000166F1 File Offset: 0x000148F1
		[global::Cpp2ILInjected.Token(Token = "0x6000C52")]
		[global::Cpp2ILInjected.Address(RVA = "0x153B930", Offset = "0x153B930", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void InternalArray__Insert<T>(int index, T item)
		{
			throw null;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000166F4 File Offset: 0x000148F4
		[global::Cpp2ILInjected.Token(Token = "0x6000C53")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A17C", Offset = "0x1C5A17C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void InternalArray__RemoveAt(int index)
		{
			throw null;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000166F7 File Offset: 0x000148F7
		[global::Cpp2ILInjected.Token(Token = "0x6000C54")]
		[global::Cpp2ILInjected.Address(RVA = "0x1520D04", Offset = "0x1520D04", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Rank", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArraySegment<>), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetLowerBound", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal int InternalArray__IndexOf<T>(T item)
		{
			throw null;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000166FA File Offset: 0x000148FA
		[global::Cpp2ILInjected.Token(Token = "0x6000C55")]
		[global::Cpp2ILInjected.Address(RVA = "0x1540E18", Offset = "0x1540E18", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal T InternalArray__get_Item<T>(int index)
		{
			throw null;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x000166FD File Offset: 0x000148FD
		[global::Cpp2ILInjected.Token(Token = "0x6000C56")]
		[global::Cpp2ILInjected.Address(RVA = "0x154C9A0", Offset = "0x154C9A0", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		internal void InternalArray__set_Item<T>(int index, T item)
		{
			throw null;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x00016700 File Offset: 0x00014900
		[global::Cpp2ILInjected.Token(Token = "0x6000C57")]
		internal void GetGenericValueImpl<T>(int pos, out T value)
		{
			throw null;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x00016703 File Offset: 0x00014903
		[global::Cpp2ILInjected.Token(Token = "0x6000C58")]
		internal void SetGenericValueImpl<T>(int pos, ref T value)
		{
			throw null;
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000BB1 RID: 2993 RVA: 0x00016706 File Offset: 0x00014906
		[global::Cpp2ILInjected.Token(Token = "0x17000110")]
		public int Length
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6000C59")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C4D650", Offset = "0x1C4D650", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 132)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x00016709 File Offset: 0x00014909
		[global::Cpp2ILInjected.Token(Token = "0x17000111")]
		public int Rank
		{
			[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
			[global::Cpp2ILInjected.Token(Token = "0x6000C5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5769C", Offset = "0x1C5769C", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 37)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000BB3 RID: 2995
		[global::Cpp2ILInjected.Token(Token = "0x6000C5B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A1C8", Offset = "0x1C5A1C8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private extern int GetRank();

		// Token: 0x06000BB4 RID: 2996
		[global::Cpp2ILInjected.Token(Token = "0x6000C5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5883C", Offset = "0x1C5883C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 72)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern int GetLength(int dimension);

		// Token: 0x06000BB5 RID: 2997
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C5D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C573E8", Offset = "0x1C573E8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "InternalArray__ICollection_CopyTo", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "InternalArray__IndexOf", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.NameInfo),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.Collection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ObjectModel.ReadOnlyCollection<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.KeyCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >.ValueCollection), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Dictionary<, >), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Queue<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.Stack<>), Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.LinkedList`1", Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.Generic.SortedList`2", Member = "System.Collections.ICollection.CopyTo", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(global::System.Array),
			"Newtonsoft.Json.Serialization.JsonArrayContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "Read", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern int GetLowerBound(int dimension);

		// Token: 0x06000BB6 RID: 2998
		[global::Cpp2ILInjected.Token(Token = "0x6000C5E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58C74", Offset = "0x1C58C74", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "WriteRectangle", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo),
			typeof(int),
			typeof(int[]),
			typeof(global::System.Array),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.NameInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(global::System.Array),
			"Newtonsoft.Json.Serialization.JsonArrayContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern object GetValue(params int[] indices);

		// Token: 0x06000BB7 RID: 2999
		[global::Cpp2ILInjected.Token(Token = "0x6000C5F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59ABC", Offset = "0x1C59ABC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "InvokeMember", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.Binder),
			typeof(object),
			typeof(object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[])
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Runtime.Serialization.ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ParseArrayMember", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ValueFixup), Member = "Fixup", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.CollectionUtils", Member = "CopyFromJaggedToMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IList),
			typeof(global::System.Array),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		public extern void SetValue(object value, params int[] indices);

		// Token: 0x06000BB8 RID: 3000
		[global::Cpp2ILInjected.Token(Token = "0x6000C60")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A1CC", Offset = "0x1C5A1CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern object GetValueImpl(int pos);

		// Token: 0x06000BB9 RID: 3001
		[global::Cpp2ILInjected.Token(Token = "0x6000C61")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A1D0", Offset = "0x1C5A1D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal extern void SetValueImpl(object value, int pos);

		// Token: 0x06000BBA RID: 3002
		[global::Cpp2ILInjected.Token(Token = "0x6000C62")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A1D4", Offset = "0x1C5A1D4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeMethodInfo), Member = "GetParameters", ReturnType = typeof(global::System.Reflection.ParameterInfo[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern bool FastCopy(global::System.Array source, int source_idx, global::System.Array dest, int dest_idx, int length);

		// Token: 0x06000BBB RID: 3003
		[global::Cpp2ILInjected.Token(Token = "0x6000C63")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A1D8", Offset = "0x1C5A1D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		internal static extern global::System.Array CreateInstanceImpl(global::System.Type elementType, int[] lengths, int[] bounds);

		// Token: 0x06000BBC RID: 3004 RVA: 0x0001670C File Offset: 0x0001490C
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C64")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A1DC", Offset = "0x1C5A1DC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectWriter), Member = "WriteArray", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.NameInfo),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.WriteObjectInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalWriter", Member = "SerializeMultidimensionalArray", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonWriter",
			typeof(global::System.Array),
			"Newtonsoft.Json.Serialization.JsonArrayContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(int),
			"System.Int32[]"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public int GetUpperBound(int dimension)
		{
			throw null;
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0001670F File Offset: 0x0001490F
		[global::Cpp2ILInjected.Token(Token = "0x6000C65")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C4D6B0", Offset = "0x1C4D6B0", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 54)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public object GetValue(int index)
		{
			throw null;
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x00016712 File Offset: 0x00014912
		[global::Cpp2ILInjected.Token(Token = "0x6000C66")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58964", Offset = "0x1C58964", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object GetValue(int index1, int index2)
		{
			throw null;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x00016715 File Offset: 0x00014915
		[global::Cpp2ILInjected.Token(Token = "0x6000C67")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C58A94", Offset = "0x1C58A94", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public object GetValue(int index1, int index2, int index3)
		{
			throw null;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x00016718 File Offset: 0x00014918
		[global::Cpp2ILInjected.Token(Token = "0x6000C68")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5715C", Offset = "0x1C5715C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void SetValue(object value, int index)
		{
			throw null;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0001671B File Offset: 0x0001491B
		[global::Cpp2ILInjected.Token(Token = "0x6000C69")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59784", Offset = "0x1C59784", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetValue(object value, int index1, int index2)
		{
			throw null;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0001671E File Offset: 0x0001491E
		[global::Cpp2ILInjected.Token(Token = "0x6000C6A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C598C4", Offset = "0x1C598C4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetValue(object value, int index1, int index2, int index3)
		{
			throw null;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x00016721 File Offset: 0x00014921
		[global::Cpp2ILInjected.Token(Token = "0x6000C6B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A214", Offset = "0x1C5A214", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ParseArray", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		internal static global::System.Array UnsafeCreateInstance(global::System.Type elementType, int[] lengths, int[] lowerBounds)
		{
			throw null;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x00016724 File Offset: 0x00014924
		[global::Cpp2ILInjected.Token(Token = "0x6000C6C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A5D0", Offset = "0x1C5A5D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static global::System.Array UnsafeCreateInstance(global::System.Type elementType, int length1, int length2)
		{
			throw null;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x00016727 File Offset: 0x00014927
		[global::Cpp2ILInjected.Token(Token = "0x6000C6D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A63C", Offset = "0x1C5A63C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.DefaultBinder), Member = "BindToMethod", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.BindingFlags),
			typeof(global::System.Reflection.MethodBase[]),
			typeof(ref object[]),
			typeof(global::System.Reflection.ParameterModifier[]),
			typeof(global::System.Globalization.CultureInfo),
			typeof(string[]),
			typeof(ref object)
		}, ReturnType = typeof(global::System.Reflection.MethodBase))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ParseArray", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		internal static global::System.Array UnsafeCreateInstance(global::System.Type elementType, params int[] lengths)
		{
			throw null;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0001672A File Offset: 0x0001492A
		[global::Cpp2ILInjected.Token(Token = "0x6000C6E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A640", Offset = "0x1C5A640", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LayoutDefinition", Member = "LoadFields", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			typeof(global::System.Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Attribute), Member = "InternalParamGetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ParameterInfo),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(global::System.Attribute[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.RuntimeType), Member = "GetEnumValues", ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.MonoCustomAttrs), Member = "GetCustomAttributes", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ICustomAttributeProvider),
			typeof(global::System.Type),
			typeof(bool)
		}, ReturnType = typeof(object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Collections.ArrayList.IListWrapper", Member = "ToArray", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.ArrayList), Member = "ToArray", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.CookieContainer", Member = "AgeCookies", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.Schema.XmlBaseConverter", Member = ".ctor", MemberParameters = new object[] { "System.Xml.Schema.XmlBaseConverter" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Serialization.JsonSerializerInternalReader", Member = "CreateList", MemberParameters = new object[]
		{
			"Newtonsoft.Json.JsonReader",
			typeof(global::System.Type),
			"Newtonsoft.Json.Serialization.JsonContract",
			"Newtonsoft.Json.Serialization.JsonProperty",
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Array CreateInstance(global::System.Type elementType, int length)
		{
			throw null;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0001672D File Offset: 0x0001492D
		[global::Cpp2ILInjected.Token(Token = "0x6000C6F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A5D4", Offset = "0x1C5A5D4", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Array CreateInstance(global::System.Type elementType, int length1, int length2)
		{
			throw null;
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x00016730 File Offset: 0x00014930
		[global::Cpp2ILInjected.Token(Token = "0x6000C70")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A6A4", Offset = "0x1C5A6A4", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static global::System.Array CreateInstance(global::System.Type elementType, int length1, int length2, int length3)
		{
			throw null;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x00016733 File Offset: 0x00014933
		[global::Cpp2ILInjected.Token(Token = "0x6000C71")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C56EC4", Offset = "0x1C56EC4", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "UnsafeCreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int[])
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "CreateInstance", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Newtonsoft.Json.Utilities.CollectionUtils", Member = "ToMultidimensionalArray", MemberParameters = new object[]
		{
			typeof(global::System.Collections.IList),
			typeof(global::System.Type),
			typeof(int)
		}, ReturnType = typeof(global::System.Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public static global::System.Array CreateInstance(global::System.Type elementType, params int[] lengths)
		{
			throw null;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x00016736 File Offset: 0x00014936
		[global::Cpp2ILInjected.Token(Token = "0x6000C72")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A218", Offset = "0x1C5A218", Length = "0x3B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypeLoadException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public static global::System.Array CreateInstance(global::System.Type elementType, int[] lengths, int[] lowerBounds)
		{
			throw null;
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x00016739 File Offset: 0x00014939
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C73")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C573EC", Offset = "0x1C573EC", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 423)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void Clear(global::System.Array array, int index, int length)
		{
			throw null;
		}

		// Token: 0x06000BCC RID: 3020
		[global::Cpp2ILInjected.Token(Token = "0x6000C74")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A71C", Offset = "0x1C5A71C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[MethodImpl(4096)]
		private static extern void ClearInternal(global::System.Array a, int index, int count);

		// Token: 0x06000BCD RID: 3021 RVA: 0x0001673C File Offset: 0x0001493C
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C75")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C585DC", Offset = "0x1C585DC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 60)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void Copy(global::System.Array sourceArray, global::System.Array destinationArray, int length)
		{
			throw null;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0001673F File Offset: 0x0001493F
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.MayCorruptInstance, global::System.Runtime.ConstrainedExecution.Cer.MayFail)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C76")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C576A0", Offset = "0x1C576A0", Length = "0x4F4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 241)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidCastException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RankException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CreateArrayTypeMismatchException", ReturnType = typeof(global::System.ArrayTypeMismatchException))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "CanAssignArrayElement", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
		public static void Copy(global::System.Array sourceArray, int sourceIndex, global::System.Array destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x00016742 File Offset: 0x00014942
		[global::Cpp2ILInjected.Token(Token = "0x6000C77")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A720", Offset = "0x1C5A720", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArrayTypeMismatchException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static global::System.ArrayTypeMismatchException CreateArrayTypeMismatchException()
		{
			throw null;
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x00016745 File Offset: 0x00014945
		[global::Cpp2ILInjected.Token(Token = "0x6000C78")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A774", Offset = "0x1C5A774", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsInterface", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool CanAssignArrayElement(global::System.Type source, global::System.Type target)
		{
			throw null;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x00016748 File Offset: 0x00014948
		[global::System.Runtime.ConstrainedExecution.ReliabilityContract(global::System.Runtime.ConstrainedExecution.Consistency.WillNotCorruptState, global::System.Runtime.ConstrainedExecution.Cer.Success)]
		[global::Cpp2ILInjected.Token(Token = "0x6000C79")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A840", Offset = "0x1C5A840", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "ArrayAppend", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T[]&", "T[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public static void ConstrainedCopy(global::System.Array sourceArray, int sourceIndex, global::System.Array destinationArray, int destinationIndex, int length)
		{
			throw null;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0001674B File Offset: 0x0001494B
		[global::Cpp2ILInjected.Token(Token = "0x6000C7A")]
		[global::Cpp2ILInjected.Address(RVA = "0x14D79B8", Offset = "0x14D79B8", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public static T[] Empty<T>()
		{
			throw null;
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0001674E File Offset: 0x0001494E
		[global::Cpp2ILInjected.Token(Token = "0x6000C7B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5A844", Offset = "0x1C5A844", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x00016751 File Offset: 0x00014951
		[global::Cpp2ILInjected.Token(Token = "0x6000C7C")]
		[global::Cpp2ILInjected.Address(RVA = "0x14DD390", Offset = "0x14DD390", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int IndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x00016754 File Offset: 0x00014954
		[global::Cpp2ILInjected.Token(Token = "0x6000C7D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1562DA8", Offset = "0x1562DA8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int LastIndexOfImpl<T>(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00016757 File Offset: 0x00014957
		[global::Cpp2ILInjected.Token(Token = "0x6000C7E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C59F74", Offset = "0x1C59F74", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "Sort", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int),
			typeof(int),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "Sort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object[]),
			typeof(global::System.Collections.IComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntrospectiveSort", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void SortImpl(global::System.Array keys, global::System.Array items, int index, int length, global::System.Collections.IComparer comparer)
		{
			throw null;
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0001675A File Offset: 0x0001495A
		[global::Cpp2ILInjected.Token(Token = "0x6000C7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x157178C", Offset = "0x157178C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static T UnsafeLoad<T>(T[] array, int index)
		{
			throw null;
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0001675D File Offset: 0x0001495D
		[global::Cpp2ILInjected.Token(Token = "0x6000C80")]
		[global::Cpp2ILInjected.Address(RVA = "0x15717A8", Offset = "0x15717A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static void UnsafeStore<T>(T[] array, int index, T value)
		{
			throw null;
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x00016760 File Offset: 0x00014960
		[global::Cpp2ILInjected.Token(Token = "0x6000C81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1571798", Offset = "0x1571798", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static R UnsafeMov<S, R>(S instance)
		{
			throw null;
		}

		// Token: 0x02000586 RID: 1414
		[global::Cpp2ILInjected.Token(Token = "0x2000135")]
		private sealed class ArrayEnumerator : global::System.Collections.IEnumerator, global::System.ICloneable
		{
			// Token: 0x06003F97 RID: 16279 RVA: 0x0001F985 File Offset: 0x0001DB85
			[global::Cpp2ILInjected.Token(Token = "0x6000C82")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5A0D4", Offset = "0x1C5A0D4", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			internal ArrayEnumerator(global::System.Array array)
			{
				throw null;
			}

			// Token: 0x06003F98 RID: 16280 RVA: 0x0001F988 File Offset: 0x0001DB88
			[global::Cpp2ILInjected.Token(Token = "0x6000C83")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5A8C8", Offset = "0x1C5A8C8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x06003F99 RID: 16281 RVA: 0x0001F98B File Offset: 0x0001DB8B
			[global::Cpp2ILInjected.Token(Token = "0x6000C84")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5A8F0", Offset = "0x1C5A8F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Reset()
			{
				throw null;
			}

			// Token: 0x06003F9A RID: 16282 RVA: 0x0001F98E File Offset: 0x0001DB8E
			[global::Cpp2ILInjected.Token(Token = "0x6000C85")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5A8FC", Offset = "0x1C5A8FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "MemberwiseClone", ReturnType = typeof(object))]
			public object Clone()
			{
				throw null;
			}

			// Token: 0x1700071D RID: 1821
			// (get) Token: 0x06003F9B RID: 16283 RVA: 0x0001F991 File Offset: 0x0001DB91
			[global::Cpp2ILInjected.Token(Token = "0x17000112")]
			public object Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C86")]
				[global::Cpp2ILInjected.Address(RVA = "0x1C5A904", Offset = "0x1C5A904", Length = "0xFC")]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040017F9 RID: 6137
			[global::Cpp2ILInjected.Token(Token = "0x40004D1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Array _array;

			// Token: 0x040017FA RID: 6138
			[global::Cpp2ILInjected.Token(Token = "0x40004D2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int _index;

			// Token: 0x040017FB RID: 6139
			[global::Cpp2ILInjected.Token(Token = "0x40004D3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private int _endIndex;
		}

		// Token: 0x02000587 RID: 1415
		[global::Cpp2ILInjected.Token(Token = "0x2000136")]
		[StructLayout(0)]
		private class RawData
		{
			// Token: 0x040017FC RID: 6140
			[global::Cpp2ILInjected.Token(Token = "0x40004D4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public global::System.IntPtr Bounds;

			// Token: 0x040017FD RID: 6141
			[global::Cpp2ILInjected.Token(Token = "0x40004D5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public global::System.IntPtr Count;

			// Token: 0x040017FE RID: 6142
			[global::Cpp2ILInjected.Token(Token = "0x40004D6")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public byte Data;
		}

		// Token: 0x02000588 RID: 1416
		[global::Cpp2ILInjected.Token(Token = "0x2000137")]
		internal struct InternalEnumerator<T> : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06003F9C RID: 16284 RVA: 0x0001F994 File Offset: 0x0001DB94
			[global::Cpp2ILInjected.Token(Token = "0x6000C87")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BD038", Offset = "0x16BD038", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "InternalArray__IEnumerable_GetEnumerator", MemberTypeParameters = new object[] { "T" }, ReturnType = "System.Collections.Generic.IEnumerator`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal InternalEnumerator(global::System.Array array)
			{
				throw null;
			}

			// Token: 0x06003F9D RID: 16285 RVA: 0x0001F997 File Offset: 0x0001DB97
			[global::Cpp2ILInjected.Token(Token = "0x6000C88")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BD048", Offset = "0x16BD048", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06003F9E RID: 16286 RVA: 0x0001F99A File Offset: 0x0001DB9A
			[global::Cpp2ILInjected.Token(Token = "0x6000C89")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BD04C", Offset = "0x16BD04C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700071E RID: 1822
			// (get) Token: 0x06003F9F RID: 16287 RVA: 0x0001F99D File Offset: 0x0001DB9D
			[global::Cpp2ILInjected.Token(Token = "0x17000113")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C8A")]
				[global::Cpp2ILInjected.Address(RVA = "0x16BD094", Offset = "0x16BD094", Length = "0x118")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.InternalEnumerator<>), Member = "System.Collections.IEnumerator.get_Current", ReturnType = typeof(object))]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003FA0 RID: 16288 RVA: 0x0001F9A0 File Offset: 0x0001DBA0
			[global::Cpp2ILInjected.Token(Token = "0x6000C8B")]
			[global::Cpp2ILInjected.Address(RVA = "0x16BD1AC", Offset = "0x16BD1AC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700071F RID: 1823
			// (get) Token: 0x06003FA1 RID: 16289 RVA: 0x0001F9A3 File Offset: 0x0001DBA3
			[global::Cpp2ILInjected.Token(Token = "0x17000114")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C8C")]
				[global::Cpp2ILInjected.Address(RVA = "0x16BD1B8", Offset = "0x16BD1B8", Length = "0x7C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.InternalEnumerator<>), Member = "get_Current", ReturnType = "T")]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
				get
				{
					throw null;
				}
			}

			// Token: 0x040017FF RID: 6143
			[global::Cpp2ILInjected.Token(Token = "0x40004D7")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private readonly global::System.Array array;

			// Token: 0x04001800 RID: 6144
			[global::Cpp2ILInjected.Token(Token = "0x40004D8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private int idx;
		}

		// Token: 0x02000589 RID: 1417
		[global::Cpp2ILInjected.Token(Token = "0x2000138")]
		internal class EmptyInternalEnumerator<T> : global::System.Collections.Generic.IEnumerator<T>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x06003FA2 RID: 16290 RVA: 0x0001F9A6 File Offset: 0x0001DBA6
			[global::Cpp2ILInjected.Token(Token = "0x6000C8D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1623598", Offset = "0x1623598", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public void Dispose()
			{
				throw null;
			}

			// Token: 0x06003FA3 RID: 16291 RVA: 0x0001F9A9 File Offset: 0x0001DBA9
			[global::Cpp2ILInjected.Token(Token = "0x6000C8E")]
			[global::Cpp2ILInjected.Address(RVA = "0x162359C", Offset = "0x162359C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public bool MoveNext()
			{
				throw null;
			}

			// Token: 0x17000720 RID: 1824
			// (get) Token: 0x06003FA4 RID: 16292 RVA: 0x0001F9AC File Offset: 0x0001DBAC
			[global::Cpp2ILInjected.Token(Token = "0x17000115")]
			public T Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C8F")]
				[global::Cpp2ILInjected.Address(RVA = "0x16235A4", Offset = "0x16235A4", Length = "0x4C")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
				get
				{
					throw null;
				}
			}

			// Token: 0x17000721 RID: 1825
			// (get) Token: 0x06003FA5 RID: 16293 RVA: 0x0001F9AF File Offset: 0x0001DBAF
			[global::Cpp2ILInjected.Token(Token = "0x17000116")]
			private object System.Collections.IEnumerator.Current
			{
				[global::Cpp2ILInjected.Token(Token = "0x6000C90")]
				[global::Cpp2ILInjected.Address(RVA = "0x16235F0", Offset = "0x16235F0", Length = "0x50")]
				[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
				[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06003FA6 RID: 16294 RVA: 0x0001F9B2 File Offset: 0x0001DBB2
			[global::Cpp2ILInjected.Token(Token = "0x6000C91")]
			[global::Cpp2ILInjected.Address(RVA = "0x1623640", Offset = "0x1623640", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x06003FA7 RID: 16295 RVA: 0x0001F9B5 File Offset: 0x0001DBB5
			[global::Cpp2ILInjected.Token(Token = "0x6000C92")]
			[global::Cpp2ILInjected.Address(RVA = "0x1623644", Offset = "0x1623644", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public EmptyInternalEnumerator()
			{
				throw null;
			}

			// Token: 0x06003FA8 RID: 16296 RVA: 0x0001F9B8 File Offset: 0x0001DBB8
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000C93")]
			[global::Cpp2ILInjected.Address(RVA = "0x162364C", Offset = "0x162364C", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static EmptyInternalEnumerator()
			{
				throw null;
			}

			// Token: 0x04001801 RID: 6145
			[global::Cpp2ILInjected.Token(Token = "0x40004D9")]
			public static readonly global::System.Array.EmptyInternalEnumerator<T> Value;
		}

		// Token: 0x0200058A RID: 1418
		[global::Cpp2ILInjected.Token(Token = "0x2000139")]
		private struct SorterObjectArray
		{
			// Token: 0x06003FA9 RID: 16297 RVA: 0x0001F9BB File Offset: 0x0001DBBB
			[global::Cpp2ILInjected.Token(Token = "0x6000C94")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5A848", Offset = "0x1C5A848", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "SortImpl", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(global::System.Collections.IComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal SorterObjectArray(object[] keys, object[] items, global::System.Collections.IComparer comparer)
			{
				throw null;
			}

			// Token: 0x06003FAA RID: 16298 RVA: 0x0001F9BE File Offset: 0x0001DBBE
			[global::Cpp2ILInjected.Token(Token = "0x6000C95")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5AA00", Offset = "0x1C5AA00", Length = "0x19C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "PickPivotAndPartition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				throw null;
			}

			// Token: 0x06003FAB RID: 16299 RVA: 0x0001F9C1 File Offset: 0x0001DBC1
			[global::Cpp2ILInjected.Token(Token = "0x6000C96")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5AB9C", Offset = "0x1C5AB9C", Length = "0xF0")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "PickPivotAndPartition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "Heapsort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			private void Swap(int i, int j)
			{
				throw null;
			}

			// Token: 0x06003FAC RID: 16300 RVA: 0x0001F9C4 File Offset: 0x0001DBC4
			[global::Cpp2ILInjected.Token(Token = "0x6000C97")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5A8C4", Offset = "0x1C5A8C4", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntrospectiveSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			internal void Sort(int left, int length)
			{
				throw null;
			}

			// Token: 0x06003FAD RID: 16301 RVA: 0x0001F9C7 File Offset: 0x0001DBC7
			[global::Cpp2ILInjected.Token(Token = "0x6000C98")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5AC8C", Offset = "0x1C5AC8C", Length = "0x140")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "Sort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "SortImpl", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(global::System.Collections.IComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void IntrospectiveSort(int left, int length)
			{
				throw null;
			}

			// Token: 0x06003FAE RID: 16302 RVA: 0x0001F9CA File Offset: 0x0001DBCA
			[global::Cpp2ILInjected.Token(Token = "0x6000C99")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5ADCC", Offset = "0x1C5ADCC", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntrospectiveSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "PickPivotAndPartition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "Heapsort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "SwapIfGreaterWithItems", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				throw null;
			}

			// Token: 0x06003FAF RID: 16303 RVA: 0x0001F9CD File Offset: 0x0001DBCD
			[global::Cpp2ILInjected.Token(Token = "0x6000C9A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B190", Offset = "0x1C5B190", Length = "0x1EC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "SwapIfGreaterWithItems", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "Swap", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private int PickPivotAndPartition(int lo, int hi)
			{
				throw null;
			}

			// Token: 0x06003FB0 RID: 16304 RVA: 0x0001F9D0 File Offset: 0x0001DBD0
			[global::Cpp2ILInjected.Token(Token = "0x6000C9B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B0F0", Offset = "0x1C5B0F0", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "DownHeap", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterObjectArray), Member = "Swap", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			private void Heapsort(int lo, int hi)
			{
				throw null;
			}

			// Token: 0x06003FB1 RID: 16305 RVA: 0x0001F9D3 File Offset: 0x0001DBD3
			[global::Cpp2ILInjected.Token(Token = "0x6000C9C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B37C", Offset = "0x1C5B37C", Length = "0x2B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterObjectArray), Member = "Heapsort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			private void DownHeap(int i, int n, int lo)
			{
				throw null;
			}

			// Token: 0x06003FB2 RID: 16306 RVA: 0x0001F9D6 File Offset: 0x0001DBD6
			[global::Cpp2ILInjected.Token(Token = "0x6000C9D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5AEE0", Offset = "0x1C5AEE0", Length = "0x210")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			private void InsertionSort(int lo, int hi)
			{
				throw null;
			}

			// Token: 0x04001802 RID: 6146
			[global::Cpp2ILInjected.Token(Token = "0x40004DA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private object[] keys;

			// Token: 0x04001803 RID: 6147
			[global::Cpp2ILInjected.Token(Token = "0x40004DB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private object[] items;

			// Token: 0x04001804 RID: 6148
			[global::Cpp2ILInjected.Token(Token = "0x40004DC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Collections.IComparer comparer;
		}

		// Token: 0x0200058B RID: 1419
		[global::Cpp2ILInjected.Token(Token = "0x200013A")]
		private struct SorterGenericArray
		{
			// Token: 0x06003FB3 RID: 16307 RVA: 0x0001F9D9 File Offset: 0x0001DBD9
			[global::Cpp2ILInjected.Token(Token = "0x6000C9E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B62C", Offset = "0x1C5B62C", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "SortImpl", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(global::System.Collections.IComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal SorterGenericArray(global::System.Array keys, global::System.Array items, global::System.Collections.IComparer comparer)
			{
				throw null;
			}

			// Token: 0x06003FB4 RID: 16308 RVA: 0x0001F9DC File Offset: 0x0001DBDC
			[global::Cpp2ILInjected.Token(Token = "0x6000C9F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B6A8", Offset = "0x1C5B6A8", Length = "0x1AC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "PickPivotAndPartition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal void SwapIfGreaterWithItems(int a, int b)
			{
				throw null;
			}

			// Token: 0x06003FB5 RID: 16309 RVA: 0x0001F9DF File Offset: 0x0001DBDF
			[global::Cpp2ILInjected.Token(Token = "0x6000CA0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B854", Offset = "0x1C5B854", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "PickPivotAndPartition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "Heapsort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			private void Swap(int i, int j)
			{
				throw null;
			}

			// Token: 0x06003FB6 RID: 16310 RVA: 0x0001F9E2 File Offset: 0x0001DBE2
			[global::Cpp2ILInjected.Token(Token = "0x6000CA1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B928", Offset = "0x1C5B928", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallAnalysisNotSupported]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array), Member = "SortImpl", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(global::System.Array),
				typeof(int),
				typeof(int),
				typeof(global::System.Collections.IComparer)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			internal void Sort(int left, int length)
			{
				throw null;
			}

			// Token: 0x06003FB7 RID: 16311 RVA: 0x0001F9E5 File Offset: 0x0001DBE5
			[global::Cpp2ILInjected.Token(Token = "0x6000CA2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5B92C", Offset = "0x1C5B92C", Length = "0x148")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "get_Length", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.IntrospectiveSortUtilities), Member = "FloorLog2PlusOne", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Generic.IntrospectiveSortUtilities), Member = "ThrowOrIgnoreBadComparer", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(global::System.Exception)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private void IntrospectiveSort(int left, int length)
			{
				throw null;
			}

			// Token: 0x06003FB8 RID: 16312 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
			[global::Cpp2ILInjected.Token(Token = "0x6000CA3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5BA74", Offset = "0x1C5BA74", Length = "0x114")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "IntrospectiveSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "PickPivotAndPartition", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "Heapsort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "SwapIfGreaterWithItems", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			private void IntroSort(int lo, int hi, int depthLimit)
			{
				throw null;
			}

			// Token: 0x06003FB9 RID: 16313 RVA: 0x0001F9EB File Offset: 0x0001DBEB
			[global::Cpp2ILInjected.Token(Token = "0x6000CA4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5BE00", Offset = "0x1C5BE00", Length = "0x204")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "SwapIfGreaterWithItems", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "Swap", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private int PickPivotAndPartition(int lo, int hi)
			{
				throw null;
			}

			// Token: 0x06003FBA RID: 16314 RVA: 0x0001F9EE File Offset: 0x0001DBEE
			[global::Cpp2ILInjected.Token(Token = "0x6000CA5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5BD60", Offset = "0x1C5BD60", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "IntroSort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "DownHeap", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array.SorterGenericArray), Member = "Swap", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			private void Heapsort(int lo, int hi)
			{
				throw null;
			}

			// Token: 0x06003FBB RID: 16315 RVA: 0x0001F9F1 File Offset: 0x0001DBF1
			[global::Cpp2ILInjected.Token(Token = "0x6000CA6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5C004", Offset = "0x1C5C004", Length = "0x2A8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Array.SorterGenericArray), Member = "Heapsort", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			private void DownHeap(int i, int n, int lo)
			{
				throw null;
			}

			// Token: 0x06003FBC RID: 16316 RVA: 0x0001F9F4 File Offset: 0x0001DBF4
			[global::Cpp2ILInjected.Token(Token = "0x6000CA7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5BB88", Offset = "0x1C5BB88", Length = "0x1D8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private void InsertionSort(int lo, int hi)
			{
				throw null;
			}

			// Token: 0x04001805 RID: 6149
			[global::Cpp2ILInjected.Token(Token = "0x40004DD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			private global::System.Array keys;

			// Token: 0x04001806 RID: 6150
			[global::Cpp2ILInjected.Token(Token = "0x40004DE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			private global::System.Array items;

			// Token: 0x04001807 RID: 6151
			[global::Cpp2ILInjected.Token(Token = "0x40004DF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private global::System.Collections.IComparer comparer;
		}
	}
}
