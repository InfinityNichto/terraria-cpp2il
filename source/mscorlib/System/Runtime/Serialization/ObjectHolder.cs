using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization
{
	[global::Cpp2ILInjected.Token(Token = "0x20003DD")]
	internal sealed class ObjectHolder
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x6001F41")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5844C", Offset = "0x1B5844C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void IncrementDescendentFixups(int amount)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001F43")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5691C", Offset = "0x1B5691C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void RemoveDependency(long id)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6001F48")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B569B8", Offset = "0x1B569B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void MarkForCompletionWhenAvailable()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4000FA2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object m_object;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal long m_id;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int m_missingElementsRemaining;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_missingDecendents;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal SerializationInfo m_serInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal ISerializationSurrogate m_surrogate;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		internal FixupHolderList m_missingElements;

		[global::Cpp2ILInjected.Token(Token = "0x4000FA9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		internal LongList m_dependentObjects;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		internal ObjectHolder m_next;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		internal int m_flags;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		private bool m_markForFixupWhenAvailable;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private ValueTypeFixupInfo m_valueFixup;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private TypeLoadExceptionHolder m_typeLoad;

		[global::Cpp2ILInjected.Token(Token = "0x4000FAF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private bool m_reachable;
	}
}
