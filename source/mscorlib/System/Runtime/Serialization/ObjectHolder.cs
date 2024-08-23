using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	// Token: 0x02000335 RID: 821
	[global::Cpp2ILInjected.Token(Token = "0x20003DD")]
	internal sealed class ObjectHolder
	{
		// Token: 0x06001D00 RID: 7424 RVA: 0x0001960A File Offset: 0x0001780A
		[global::Cpp2ILInjected.Token(Token = "0x6001F3E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B54E7C", Offset = "0x1B54E7C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
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
		internal ObjectHolder(long objID)
		{
			throw null;
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x0001960D File Offset: 0x0001780D
		[global::Cpp2ILInjected.Token(Token = "0x6001F3F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57288", Offset = "0x1B57288", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal ObjectHolder(object obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, global::System.Reflection.FieldInfo field, int[] arrayIndex)
		{
			throw null;
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00019610 File Offset: 0x00017810
		[global::Cpp2ILInjected.Token(Token = "0x6001F40")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B56BD8", Offset = "0x1B56BD8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(ObjectHolder))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal ObjectHolder(string obj, long objID, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainingObj, global::System.Reflection.FieldInfo field, int[] arrayIndex)
		{
			throw null;
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00019613 File Offset: 0x00017813
		[global::Cpp2ILInjected.Token(Token = "0x6001F41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5844C", Offset = "0x1B5844C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void IncrementDescendentFixups(int amount)
		{
			throw null;
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00019616 File Offset: 0x00017816
		[global::Cpp2ILInjected.Token(Token = "0x6001F42")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B568F8", Offset = "0x1B568F8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		internal void DecrementFixupsRemaining(ObjectManager manager)
		{
			throw null;
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00019619 File Offset: 0x00017819
		[global::Cpp2ILInjected.Token(Token = "0x6001F43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5691C", Offset = "0x1B5691C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void RemoveDependency(long id)
		{
			throw null;
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x0001961C File Offset: 0x0001781C
		[global::Cpp2ILInjected.Token(Token = "0x6001F44")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57B94", Offset = "0x1B57B94", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FixupHolderList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AddFixup(FixupHolder fixup, ObjectManager manager)
		{
			throw null;
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x0001961F File Offset: 0x0001781F
		[global::Cpp2ILInjected.Token(Token = "0x6001F45")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5845C", Offset = "0x1B5845C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "DecrementFixupsRemaining", MemberParameters = new object[] { typeof(ObjectManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "AddFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[]),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "FindOrCreateObjectHolder", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(ObjectHolder))]
		private void UpdateDescendentDependencyChain(int amount, ObjectManager manager)
		{
			throw null;
		}

		// Token: 0x06001D08 RID: 7432 RVA: 0x00019622 File Offset: 0x00017822
		[global::Cpp2ILInjected.Token(Token = "0x6001F46")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B57C48", Offset = "0x1B57C48", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterFixup", MemberParameters = new object[]
		{
			typeof(FixupHolder),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LongList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LongList), Member = "Add", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AddDependency(long dependentObject)
		{
			throw null;
		}

		// Token: 0x06001D09 RID: 7433 RVA: 0x00019625 File Offset: 0x00017825
		[global::Cpp2ILInjected.Token(Token = "0x6001F47")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5745C", Offset = "0x1B5745C", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "RegisterObject", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(long),
			typeof(global::System.Reflection.MemberInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "SetObjectValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Reflection.FieldInfo), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.FieldInfo),
			typeof(global::System.Reflection.FieldInfo)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "get_IsValueType", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValueTypeFixupInfo), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "SetFlags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "UpdateDescendentDependencyChain", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SerializationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void UpdateData(object obj, SerializationInfo info, ISerializationSurrogate surrogate, long idOfContainer, global::System.Reflection.FieldInfo field, int[] arrayIndex, ObjectManager manager)
		{
			throw null;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00019628 File Offset: 0x00017828
		[global::Cpp2ILInjected.Token(Token = "0x6001F48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B569B8", Offset = "0x1B569B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void MarkForCompletionWhenAvailable()
		{
			throw null;
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x0001962B File Offset: 0x0001782B
		[global::Cpp2ILInjected.Token(Token = "0x6001F49")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B55638", Offset = "0x1B55638", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(long),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[]),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void SetFlags()
		{
			throw null;
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001D0C RID: 7436 RVA: 0x0001962E File Offset: 0x0001782E
		// (set) Token: 0x06001D0D RID: 7437 RVA: 0x00019631 File Offset: 0x00017831
		[global::Cpp2ILInjected.Token(Token = "0x17000417")]
		internal bool IsIncompleteObjectReference
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F4A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5527C", Offset = "0x1B5527C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F4B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B56234", Offset = "0x1B56234", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00019634 File Offset: 0x00017834
		[global::Cpp2ILInjected.Token(Token = "0x17000418")]
		internal bool RequiresDelayedFixup
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F4C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5744C", Offset = "0x1B5744C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001D0F RID: 7439 RVA: 0x00019637 File Offset: 0x00017837
		[global::Cpp2ILInjected.Token(Token = "0x17000419")]
		internal bool RequiresValueTypeFixup
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F4D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5596C", Offset = "0x1B5596C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001D10 RID: 7440 RVA: 0x0001963A File Offset: 0x0001783A
		// (set) Token: 0x06001D11 RID: 7441 RVA: 0x0001963D File Offset: 0x0001783D
		[global::Cpp2ILInjected.Token(Token = "0x1700041A")]
		internal bool ValueTypeFixupPerformed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F4E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B55978", Offset = "0x1B55978", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F4F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B56984", Offset = "0x1B56984", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00019640 File Offset: 0x00017840
		[global::Cpp2ILInjected.Token(Token = "0x1700041B")]
		internal bool HasISerializable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F50")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5683C", Offset = "0x1B5683C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00019643 File Offset: 0x00017843
		[global::Cpp2ILInjected.Token(Token = "0x1700041C")]
		internal bool HasSurrogate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F51")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B55494", Offset = "0x1B55494", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003BF RID: 959
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00019646 File Offset: 0x00017846
		[global::Cpp2ILInjected.Token(Token = "0x1700041D")]
		internal bool CanSurrogatedObjectValueChange
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F52")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B554A0", Offset = "0x1B554A0", Length = "0xA8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "GetCompletionInfo", MemberParameters = new object[]
			{
				typeof(FixupHolder),
				typeof(ref ObjectHolder),
				typeof(ref object),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "DoNewlyRegisteredObjectFixups", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "GetObject", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "get_CanObjectValueChange", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(global::System.Type),
				typeof(global::System.Type)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003C0 RID: 960
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00019649 File Offset: 0x00017849
		[global::Cpp2ILInjected.Token(Token = "0x1700041E")]
		internal bool CanObjectValueChange
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F53")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5525C", Offset = "0x1B5525C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectHolder), Member = "get_CanSurrogatedObjectValueChange", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003C1 RID: 961
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x0001964C File Offset: 0x0001784C
		[global::Cpp2ILInjected.Token(Token = "0x1700041F")]
		internal int DirectlyDependentObjects
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F54")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5858C", Offset = "0x1B5858C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003C2 RID: 962
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x0001964F File Offset: 0x0001784F
		[global::Cpp2ILInjected.Token(Token = "0x17000420")]
		internal int TotalDependentObjects
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F55")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B575D4", Offset = "0x1B575D4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003C3 RID: 963
		// (get) Token: 0x06001D18 RID: 7448 RVA: 0x00019652 File Offset: 0x00017852
		// (set) Token: 0x06001D19 RID: 7449 RVA: 0x00019655 File Offset: 0x00017855
		[global::Cpp2ILInjected.Token(Token = "0x17000421")]
		internal bool Reachable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F56")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B58594", Offset = "0x1B58594", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F57")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B5859C", Offset = "0x1B5859C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003C4 RID: 964
		// (get) Token: 0x06001D1A RID: 7450 RVA: 0x00019658 File Offset: 0x00017858
		[global::Cpp2ILInjected.Token(Token = "0x17000422")]
		internal bool TypeLoadExceptionReachable
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F58")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B56974", Offset = "0x1B56974", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003C5 RID: 965
		// (get) Token: 0x06001D1B RID: 7451 RVA: 0x0001965B File Offset: 0x0001785B
		// (set) Token: 0x06001D1C RID: 7452 RVA: 0x0001965E File Offset: 0x0001785E
		[global::Cpp2ILInjected.Token(Token = "0x17000423")]
		internal TypeLoadExceptionHolder TypeLoadException
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F59")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585A8", Offset = "0x1B585A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F5A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585B0", Offset = "0x1B585B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003C6 RID: 966
		// (get) Token: 0x06001D1D RID: 7453 RVA: 0x00019661 File Offset: 0x00017861
		[global::Cpp2ILInjected.Token(Token = "0x17000424")]
		internal object ObjectValue
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F5B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585B8", Offset = "0x1B585B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001D1E RID: 7454 RVA: 0x00019664 File Offset: 0x00017864
		[global::Cpp2ILInjected.Token(Token = "0x6001F5C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B55548", Offset = "0x1B55548", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "FixupSpecialObject", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectManager), Member = "ResolveObjectReference", MemberParameters = new object[] { typeof(ObjectHolder) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ObjectHolder), Member = "UpdateData", MemberParameters = new object[]
		{
			typeof(object),
			typeof(SerializationInfo),
			typeof(ISerializationSurrogate),
			typeof(long),
			typeof(global::System.Reflection.FieldInfo),
			typeof(int[]),
			typeof(ObjectManager)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ObjectManager), Member = "CompleteObject", MemberParameters = new object[]
		{
			typeof(ObjectHolder),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void SetObjectValue(object obj, ObjectManager manager)
		{
			throw null;
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x00019667 File Offset: 0x00017867
		// (set) Token: 0x06001D20 RID: 7456 RVA: 0x0001966A File Offset: 0x0001786A
		[global::Cpp2ILInjected.Token(Token = "0x17000425")]
		internal SerializationInfo SerializationInfo
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F5D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585C0", Offset = "0x1B585C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F5E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585C8", Offset = "0x1B585C8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x06001D21 RID: 7457 RVA: 0x0001966D File Offset: 0x0001786D
		[global::Cpp2ILInjected.Token(Token = "0x17000426")]
		internal ISerializationSurrogate Surrogate
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F5F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585D0", Offset = "0x1B585D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06001D22 RID: 7458 RVA: 0x00019670 File Offset: 0x00017870
		// (set) Token: 0x06001D23 RID: 7459 RVA: 0x00019673 File Offset: 0x00017873
		[global::Cpp2ILInjected.Token(Token = "0x17000427")]
		internal LongList DependentObjects
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F60")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585D8", Offset = "0x1B585D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F61")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585E0", Offset = "0x1B585E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06001D24 RID: 7460 RVA: 0x00019676 File Offset: 0x00017876
		// (set) Token: 0x06001D25 RID: 7461 RVA: 0x00019679 File Offset: 0x00017879
		[global::Cpp2ILInjected.Token(Token = "0x17000428")]
		internal bool RequiresSerInfoFixup
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F62")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B57A2C", Offset = "0x1B57A2C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001F63")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B55950", Offset = "0x1B55950", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001D26 RID: 7462 RVA: 0x0001967C File Offset: 0x0001787C
		[global::Cpp2ILInjected.Token(Token = "0x17000429")]
		internal ValueTypeFixupInfo ValueFixup
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F64")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B585E8", Offset = "0x1B585E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x0001967F File Offset: 0x0001787F
		[global::Cpp2ILInjected.Token(Token = "0x1700042A")]
		internal bool CompletelyFixed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F65")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B55238", Offset = "0x1B55238", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x00019682 File Offset: 0x00017882
		[global::Cpp2ILInjected.Token(Token = "0x1700042B")]
		internal long ContainerID
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001F66")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B58510", Offset = "0x1B58510", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000CB0 RID: 3248
		[global::Cpp2ILInjected.Token(Token = "0x4000FA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object m_object;

		// Token: 0x04000CB1 RID: 3249
		[global::Cpp2ILInjected.Token(Token = "0x4000FA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long m_id;

		// Token: 0x04000CB2 RID: 3250
		[global::Cpp2ILInjected.Token(Token = "0x4000FA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_missingElementsRemaining;

		// Token: 0x04000CB3 RID: 3251
		[global::Cpp2ILInjected.Token(Token = "0x4000FA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_missingDecendents;

		// Token: 0x04000CB4 RID: 3252
		[global::Cpp2ILInjected.Token(Token = "0x4000FA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal SerializationInfo m_serInfo;

		// Token: 0x04000CB5 RID: 3253
		[global::Cpp2ILInjected.Token(Token = "0x4000FA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ISerializationSurrogate m_surrogate;

		// Token: 0x04000CB6 RID: 3254
		[global::Cpp2ILInjected.Token(Token = "0x4000FA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal FixupHolderList m_missingElements;

		// Token: 0x04000CB7 RID: 3255
		[global::Cpp2ILInjected.Token(Token = "0x4000FA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal LongList m_dependentObjects;

		// Token: 0x04000CB8 RID: 3256
		[global::Cpp2ILInjected.Token(Token = "0x4000FAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ObjectHolder m_next;

		// Token: 0x04000CB9 RID: 3257
		[global::Cpp2ILInjected.Token(Token = "0x4000FAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int m_flags;

		// Token: 0x04000CBA RID: 3258
		[global::Cpp2ILInjected.Token(Token = "0x4000FAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private bool m_markForFixupWhenAvailable;

		// Token: 0x04000CBB RID: 3259
		[global::Cpp2ILInjected.Token(Token = "0x4000FAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ValueTypeFixupInfo m_valueFixup;

		// Token: 0x04000CBC RID: 3260
		[global::Cpp2ILInjected.Token(Token = "0x4000FAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private TypeLoadExceptionHolder m_typeLoad;

		// Token: 0x04000CBD RID: 3261
		[global::Cpp2ILInjected.Token(Token = "0x4000FAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool m_reachable;
	}
}
