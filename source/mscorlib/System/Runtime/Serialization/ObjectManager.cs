using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000334 RID: 820
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x20003DC")]
	public class ObjectManager
	{
		// Token: 0x06001CE3 RID: 7395 RVA: 0x000195B3 File Offset: 0x000177B3
		[global::Cpp2ILInjected.Token(Token = "0x6001F21")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54C7C", Offset = "0x1B54C7C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "InitFullDeserialization", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectManager(ISurrogateSelector selector, StreamingContext context, bool checkSecurity, bool isCrossAppDomain)
		{
			throw null;
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x000195B6 File Offset: 0x000177B6
		[global::Cpp2ILInjected.Token(Token = "0x6001F22")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54CFC", Offset = "0x1B54CFC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private bool CanCallGetType(object obj)
		{
			throw null;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001CE6 RID: 7398 RVA: 0x000195BC File Offset: 0x000177BC
		// (set) Token: 0x06001CE5 RID: 7397 RVA: 0x000195B9 File Offset: 0x000177B9
		[global::Cpp2ILInjected.Token(Token = "0x17000415")]
		internal object TopObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F24")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B54D0C", Offset = "0x1B54D0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F23")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B54D04", Offset = "0x1B54D04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001CE7 RID: 7399 RVA: 0x000195BF File Offset: 0x000177BF
		[global::Cpp2ILInjected.Token(Token = "0x17000416")]
		internal ObjectHolderList SpecialFixupObjects
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F25")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B54D14", Offset = "0x1B54D14", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new object[]
			{
				typeof(FixupHolder),
				typeof(ref ObjectHolder),
				typeof(ref object),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
			{
				typeof(object),
				typeof(long),
				typeof(SerializationInfo),
				typeof(long),
				typeof(global::System.Reflection.MemberInfo),
				typeof(int[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolderList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001CE8 RID: 7400 RVA: 0x000195C2 File Offset: 0x000177C2
		[global::Cpp2ILInjected.Token(Token = "0x6001F26")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54D80", Offset = "0x1B54D80", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal ObjectHolder FindObjectHolder(long objectID)
		{
			throw null;
		}

		// Token: 0x06001CE9 RID: 7401 RVA: 0x000195C5 File Offset: 0x000177C5
		[global::Cpp2ILInjected.Token(Token = "0x6001F27")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54DC0", Offset = "0x1B54DC0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "AddObjectHolder", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectHolder FindOrCreateObjectHolder(long objectID)
		{
			throw null;
		}

		// Token: 0x06001CEA RID: 7402 RVA: 0x000195C8 File Offset: 0x000177C8
		[global::Cpp2ILInjected.Token(Token = "0x6001F28")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54EB0", Offset = "0x1B54EB0", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(ObjectHolder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void AddObjectHolder(ObjectHolder holder)
		{
			throw null;
		}

		// Token: 0x06001CEB RID: 7403 RVA: 0x000195CB File Offset: 0x000177CB
		[global::Cpp2ILInjected.Token(Token = "0x6001F29")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54FA4", Offset = "0x1B54FA4", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private bool GetCompletionInfo(FixupHolder fixup, out ObjectHolder holder, out object member, bool bThrowIfMissing)
		{
			throw null;
		}

		// Token: 0x06001CEC RID: 7404 RVA: 0x000195CE File Offset: 0x000177CE
		[global::Cpp2ILInjected.Token(Token = "0x6001F2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B55288", Offset = "0x1B55288", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(global::System.IFormatProvider),
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void FixupSpecialObject(ObjectHolder holder)
		{
			throw null;
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000195D1 File Offset: 0x000177D1
		[global::Cpp2ILInjected.Token(Token = "0x6001F2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B55FC0", Offset = "0x1B55FC0", Length = "0x274")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private bool ResolveObjectReference(ObjectHolder holder)
		{
			throw null;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000195D4 File Offset: 0x000177D4
		[global::Cpp2ILInjected.Token(Token = "0x6001F2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B559B0", Offset = "0x1B559B0", Length = "0x4EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(global::System.Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Nullable), Member = "GetUnderlyingType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypedReference), Member = "MakeTypedReference", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Reflection.FieldInfo[])
		}, ReturnType = typeof(global::System.TypedReference))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TypedReference), Member = "SetTypedReference", MemberParameters = new object[]
		{
			typeof(global::System.TypedReference),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private bool DoValueTypeFixup(global::System.Reflection.FieldInfo memberToFix, ObjectHolder holder, object value)
		{
			throw null;
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000195D7 File Offset: 0x000177D7
		[global::Cpp2ILInjected.Token(Token = "0x6001F2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B56250", Offset = "0x1B56250", Length = "0x5EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoFixups", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(ref ObjectHolder),
			typeof(ref object),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationInfo), Member = "UpdateValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(global::System.Type)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "SerializationSetValue", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "DoValueTypeFixup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(ObjectHolder),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "SetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 27)]
		internal void CompleteObject(ObjectHolder holder, bool bObjectFullyComplete)
		{
			throw null;
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x000195DA File Offset: 0x000177DA
		[global::Cpp2ILInjected.Token(Token = "0x6001F2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B55E9C", Offset = "0x1B55E9C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "ResolveObjectReference", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		private void DoNewlyRegisteredObjectFixups(ObjectHolder holder)
		{
			throw null;
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x000195DD File Offset: 0x000177DD
		[global::Cpp2ILInjected.Token(Token = "0x6001F2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B56A04", Offset = "0x1B56A04", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual object GetObject(long objectID)
		{
			throw null;
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x000195E0 File Offset: 0x000177E0
		[global::Cpp2ILInjected.Token(Token = "0x6001F30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B56AE0", Offset = "0x1B56AE0", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "AddObjectHolder", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void RegisterString(string obj, long objectID, SerializationInfo info, long idOfContainingObj, global::System.Reflection.MemberInfo member)
		{
			throw null;
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x000195E3 File Offset: 0x000177E3
		[global::Cpp2ILInjected.Token(Token = "0x6001F31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B56CB4", Offset = "0x1B56CB4", Length = "0x5D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeserializationEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "AddObjectHolder", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[]),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public void RegisterObject(object obj, long objectID, SerializationInfo info, long idOfContainingObj, global::System.Reflection.MemberInfo member, int[] arrayIndex)
		{
			throw null;
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x000195E6 File Offset: 0x000177E6
		[global::Cpp2ILInjected.Token(Token = "0x6001F32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B556F0", Offset = "0x1B556F0", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "GetConstructor", MemberParameters = new object[] { typeof(global::System.RuntimeType) }, ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.RuntimeConstructorInfo), Member = "SerializationInvoke", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		internal void CompleteISerializableObject(object obj, SerializationInfo info, StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x000195E9 File Offset: 0x000177E9
		[global::Cpp2ILInjected.Token(Token = "0x6001F33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B575E0", Offset = "0x1B575E0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "CompleteISerializableObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SafeSerializationManager), Member = "System.Runtime.Serialization.IObjectReference.GetRealObject", MemberParameters = new object[] { typeof(StreamingContext) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.RuntimeType), Member = "GetSerializationCtor", ReturnType = typeof(global::System.Reflection.RuntimeConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.ConstructorInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.ConstructorInfo),
			typeof(global::System.Reflection.ConstructorInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal static global::System.Reflection.RuntimeConstructorInfo GetConstructor(global::System.RuntimeType t)
		{
			throw null;
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x000195EC File Offset: 0x000177EC
		[global::Cpp2ILInjected.Token(Token = "0x6001F34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B576EC", Offset = "0x1B576EC", Length = "0x2B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "get_SpecialFixupObjects", ReturnType = typeof(ObjectHolderList))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolderList), Member = "GetFixupEnumerator", ReturnType = typeof(ObjectHolderListEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolderListEnumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "ResolveObjectReference", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public virtual void DoFixups()
		{
			throw null;
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x000195EF File Offset: 0x000177EF
		[global::Cpp2ILInjected.Token(Token = "0x6001F35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57ACC", Offset = "0x1B57ACC", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RecordFixup", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.Reflection.MemberInfo),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RecordDelayedFixup", MemberParameters = new object[]
		{
			typeof(long),
			typeof(string),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RecordArrayElementFixup", MemberParameters = new object[]
		{
			typeof(long),
			typeof(int[]),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(ObjectHolder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "AddFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "AddDependency", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void RegisterFixup(FixupHolder fixup, long objectToBeFixed, long objectRequired)
		{
			throw null;
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x000195F2 File Offset: 0x000177F2
		[global::Cpp2ILInjected.Token(Token = "0x6001F36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57CB4", Offset = "0x1B57CB4", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.MemberInfo), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.MemberInfo),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public virtual void RecordFixup(long objectToBeFixed, global::System.Reflection.MemberInfo member, long objectRequired)
		{
			throw null;
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x000195F5 File Offset: 0x000177F5
		[global::Cpp2ILInjected.Token(Token = "0x6001F37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57F4C", Offset = "0x1B57F4C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public virtual void RecordDelayedFixup(long objectToBeFixed, string memberName, long objectRequired)
		{
			throw null;
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x000195F8 File Offset: 0x000177F8
		[global::Cpp2ILInjected.Token(Token = "0x6001F38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B580A0", Offset = "0x1B580A0", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public virtual void RecordArrayElementFixup(long arrayToBeFixed, int[] indices, long objectRequired)
		{
			throw null;
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x000195FB File Offset: 0x000177FB
		[global::Cpp2ILInjected.Token(Token = "0x6001F39")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B581F4", Offset = "0x1B581F4", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public virtual void RaiseDeserializationEvent()
		{
			throw null;
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x000195FE File Offset: 0x000177FE
		[global::Cpp2ILInjected.Token(Token = "0x6001F3A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B58240", Offset = "0x1B58240", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(global::System.Delegate),
			typeof(global::System.Delegate)
		}, ReturnType = typeof(global::System.Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual void AddOnDeserialization(DeserializationEventHandler handler)
		{
			throw null;
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00019601 File Offset: 0x00017801
		[global::Cpp2ILInjected.Token(Token = "0x6001F3B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B582C0", Offset = "0x1B582C0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(SerializationEvents))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "AddOnDelegate", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationEventHandler),
			typeof(global::System.Collections.Generic.List<global::System.Reflection.MethodInfo>)
		}, ReturnType = typeof(SerializationEventHandler))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual void AddOnDeserialized(object obj)
		{
			throw null;
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00019604 File Offset: 0x00017804
		[global::Cpp2ILInjected.Token(Token = "0x6001F3C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5834C", Offset = "0x1B5834C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(SerializationEvents))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "InvokeOnDeserialized", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal virtual void RaiseOnDeserializedEvent(object obj)
		{
			throw null;
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00019607 File Offset: 0x00017807
		[global::Cpp2ILInjected.Token(Token = "0x6001F3D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B583CC", Offset = "0x1B583CC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.ObjectReader), Member = "ParseObject", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.ParseRecord) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEventsCache), Member = "GetSerializationEventsForType", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(SerializationEvents))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationEvents), Member = "InvokeOnDeserializing", MemberParameters = new object[]
		{
			typeof(object),
			typeof(StreamingContext)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RaiseOnDeserializingEvent(object obj)
		{
			throw null;
		}

		// Token: 0x04000CA8 RID: 3240
		[global::Cpp2ILInjected.Token(Token = "0x4000F9A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DeserializationEventHandler m_onDeserializationHandler;

		// Token: 0x04000CA9 RID: 3241
		[global::Cpp2ILInjected.Token(Token = "0x4000F9B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private SerializationEventHandler m_onDeserializedHandler;

		// Token: 0x04000CAA RID: 3242
		[global::Cpp2ILInjected.Token(Token = "0x4000F9C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal ObjectHolder[] m_objects;

		// Token: 0x04000CAB RID: 3243
		[global::Cpp2ILInjected.Token(Token = "0x4000F9D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal object m_topObject;

		// Token: 0x04000CAC RID: 3244
		[global::Cpp2ILInjected.Token(Token = "0x4000F9E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ObjectHolderList m_specialFixupObjects;

		// Token: 0x04000CAD RID: 3245
		[global::Cpp2ILInjected.Token(Token = "0x4000F9F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal long m_fixupCount;

		// Token: 0x04000CAE RID: 3246
		[global::Cpp2ILInjected.Token(Token = "0x4000FA0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal ISurrogateSelector m_selector;

		// Token: 0x04000CAF RID: 3247
		[global::Cpp2ILInjected.Token(Token = "0x4000FA1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal StreamingContext m_context;
	}
}
