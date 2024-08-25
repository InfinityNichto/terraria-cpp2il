using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000352")]
	[Serializable]
	public class BindingList<T> : Collection<T>, IBindingList, IList, ICollection, IEnumerable, ICancelAddNew, IRaiseItemChangedEvents
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001610")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6130", Offset = "0x18E6130", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public BindingList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001611")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6194", Offset = "0x18E6194", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public BindingList(IList<T> list)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001612")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E61F8", Offset = "0x18E61F8", Length = "0x3A4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		private void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000504")]
		private bool ItemTypeHasDefaultConstructor
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001613")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E659C", Offset = "0x18E659C", Length = "0x12C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "get_IsPrimitive", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[]
			{
				typeof(BindingFlags),
				typeof(Binder),
				typeof(Type[]),
				typeof(ParameterModifier[])
			}, ReturnType = typeof(ConstructorInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(ConstructorInfo),
				typeof(ConstructorInfo)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000011")]
		public event AddingNewEventHandler AddingNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001614")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E66C8", Offset = "0x18E66C8", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001615")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E67C0", Offset = "0x18E67C0", Length = "0xF8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001616")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E68B8", Offset = "0x18E68B8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnAddingNew(AddingNewEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001617")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E68E0", Offset = "0x18E68E0", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AddingNewEventArgs), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private object FireAddingNew()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000012")]
		public event ListChangedEventHandler ListChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001618")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E6954", Offset = "0x18E6954", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001619")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E69D4", Offset = "0x18E69D4", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600161A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6A54", Offset = "0x18E6A54", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected virtual void OnListChanged(ListChangedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000505")]
		public bool RaiseListChangedEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x600161B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E6A7C", Offset = "0x18E6A7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600161C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E6A84", Offset = "0x18E6A84", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600161D")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6A90", Offset = "0x18E6A90", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ResetBindings()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600161E")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6AAC", Offset = "0x18E6AAC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ResetItem(int position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600161F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6AC8", Offset = "0x18E6AC8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void FireListChanged(ListChangedType type, int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001620")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6B60", Offset = "0x18E6B60", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		protected override void ClearItems()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001621")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6EB8", Offset = "0x18E6EB8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void InsertItem(int index, T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001622")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E6F5C", Offset = "0x18E6F5C", Length = "0x100")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected override void RemoveItem(int index)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001623")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E705C", Offset = "0x18E705C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected override void SetItem(int index, T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001624")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7128", Offset = "0x18E7128", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void CancelNew(int itemIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001625")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7160", Offset = "0x18E7160", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public virtual void EndNew(int itemIndex)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001626")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E717C", Offset = "0x18E717C", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T AddNew()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001627")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E726C", Offset = "0x18E726C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private object System.ComponentModel.IBindingList.AddNew()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000506")]
		private bool AddingNewHandled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001628")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7318", Offset = "0x18E7318", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001629")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7344", Offset = "0x18E7344", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SecurityUtils), Member = "SecureCreateInstance", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		protected virtual object AddNewCore()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000507")]
		public bool AllowNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E744C", Offset = "0x18E744C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600162B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7480", Offset = "0x18E7480", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000508")]
		private bool System.ComponentModel.IBindingList.AllowNew
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7500", Offset = "0x18E7500", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000509")]
		public bool AllowEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7514", Offset = "0x18E7514", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600162E")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E751C", Offset = "0x18E751C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700050A")]
		private bool System.ComponentModel.IBindingList.AllowEdit
		{
			[global::Cpp2ILInjected.Token(Token = "0x600162F")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7550", Offset = "0x18E7550", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700050B")]
		public bool AllowRemove
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001630")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7564", Offset = "0x18E7564", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001631")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E756C", Offset = "0x18E756C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700050C")]
		private bool System.ComponentModel.IBindingList.AllowRemove
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001632")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75A0", Offset = "0x18E75A0", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700050D")]
		private bool System.ComponentModel.IBindingList.SupportsChangeNotification
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001633")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75B4", Offset = "0x18E75B4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700050E")]
		protected virtual bool SupportsChangeNotificationCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001634")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75C4", Offset = "0x18E75C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700050F")]
		private bool System.ComponentModel.IBindingList.SupportsSearching
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001635")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75CC", Offset = "0x18E75CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000510")]
		protected virtual bool SupportsSearchingCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001636")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75DC", Offset = "0x18E75DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000511")]
		private bool System.ComponentModel.IBindingList.SupportsSorting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001637")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75E4", Offset = "0x18E75E4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000512")]
		protected virtual bool SupportsSortingCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001638")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75F4", Offset = "0x18E75F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000513")]
		private bool System.ComponentModel.IBindingList.IsSorted
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001639")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E75FC", Offset = "0x18E75FC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000514")]
		protected virtual bool IsSortedCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E760C", Offset = "0x18E760C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000515")]
		private PropertyDescriptor System.ComponentModel.IBindingList.SortProperty
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163B")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7614", Offset = "0x18E7614", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000516")]
		protected virtual PropertyDescriptor SortPropertyCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163C")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7624", Offset = "0x18E7624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000517")]
		private ListSortDirection System.ComponentModel.IBindingList.SortDirection
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163D")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E762C", Offset = "0x18E762C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000518")]
		protected virtual ListSortDirection SortDirectionCore
		{
			[global::Cpp2ILInjected.Token(Token = "0x600163E")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E763C", Offset = "0x18E763C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x600163F")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7644", Offset = "0x18E7644", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.ComponentModel.IBindingList.ApplySort(PropertyDescriptor prop, ListSortDirection direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001640")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7654", Offset = "0x18E7654", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001641")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E768C", Offset = "0x18E768C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void System.ComponentModel.IBindingList.RemoveSort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001642")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E769C", Offset = "0x18E769C", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual void RemoveSortCore()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001643")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E76D4", Offset = "0x18E76D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private int System.ComponentModel.IBindingList.Find(PropertyDescriptor prop, object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001644")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E76E4", Offset = "0x18E76E4", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		protected virtual int FindCore(PropertyDescriptor prop, object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001645")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E771C", Offset = "0x18E771C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.ComponentModel.IBindingList.AddIndex(PropertyDescriptor prop)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001646")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7720", Offset = "0x18E7720", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private void System.ComponentModel.IBindingList.RemoveIndex(PropertyDescriptor prop)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001647")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7724", Offset = "0x18E7724", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PropertyChangedEventHandler), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private void HookPropertyChanged(T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001648")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7834", Offset = "0x18E7834", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UnhookPropertyChanged(T item)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001649")]
		[global::Cpp2ILInjected.Address(RVA = "0x18E7908", Offset = "0x18E7908", Length = "0x314")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TypeDescriptor), Member = "GetProperties", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(PropertyDescriptorCollection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ListChangedEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(ListChangedType),
			typeof(int),
			typeof(PropertyDescriptor)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private void Child_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000519")]
		private bool System.ComponentModel.IRaiseItemChangedEvents.RaisesItemChangedEvents
		{
			[global::Cpp2ILInjected.Token(Token = "0x600164A")]
			[global::Cpp2ILInjected.Address(RVA = "0x18E7C1C", Offset = "0x18E7C1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40011CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int addNewPos;

		[global::Cpp2ILInjected.Token(Token = "0x40011CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool raiseListChangedEvents;

		[global::Cpp2ILInjected.Token(Token = "0x40011CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool raiseItemChangedEvents;

		[global::Cpp2ILInjected.Token(Token = "0x40011CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private PropertyDescriptorCollection _itemTypeProperties;

		[global::Cpp2ILInjected.Token(Token = "0x40011CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private PropertyChangedEventHandler _propertyChangedEventHandler;

		[global::Cpp2ILInjected.Token(Token = "0x40011D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private AddingNewEventHandler _onAddingNew;

		[global::Cpp2ILInjected.Token(Token = "0x40011D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private ListChangedEventHandler _onListChanged;

		[global::Cpp2ILInjected.Token(Token = "0x40011D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private int _lastChangeIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40011D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool allowNew;

		[global::Cpp2ILInjected.Token(Token = "0x40011D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool allowEdit;

		[global::Cpp2ILInjected.Token(Token = "0x40011D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool allowRemove;

		[global::Cpp2ILInjected.Token(Token = "0x40011D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private bool userSetAllowNew;
	}
}
