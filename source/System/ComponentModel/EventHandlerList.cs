﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x2000339")]
	public sealed class EventHandlerList : IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x600158C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C5E4", Offset = "0x1E3C5E4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "get_Events", ReturnType = typeof(EventHandlerList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal EventHandlerList(Component parent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600158D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C60C", Offset = "0x1E3C60C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarshalByValueComponent), Member = "get_Events", ReturnType = typeof(EventHandlerList))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EventHandlerList()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170004E9")]
		public Delegate this[object key]
		{
			[global::Cpp2ILInjected.Token(Token = "0x600158E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C614", Offset = "0x1E3C614", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarshalByValueComponent), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_CanRaiseEventsInternal", ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600158F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C68C", Offset = "0x1E3C68C", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001590")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C760", Offset = "0x1E3C760", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EventHandlerList), Member = "AddHandlers", MemberParameters = new object[] { typeof(EventHandlerList) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarshalByValueComponent), Member = "add_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "add_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddHandler(object key, Delegate value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001591")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C808", Offset = "0x1E3C808", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EventHandlerList), Member = "AddHandler", MemberParameters = new object[]
		{
			typeof(object),
			typeof(Delegate)
		}, ReturnType = typeof(void))]
		public void AddHandlers(EventHandlerList listToAddFrom)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001592")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C83C", Offset = "0x1E3C83C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dispose()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001593")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C674", Offset = "0x1E3C674", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private EventHandlerList.ListEntry Find(object key)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001594")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E3C844", Offset = "0x1E3C844", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MarshalByValueComponent), Member = "remove_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Component), Member = "remove_Disposed", MemberParameters = new object[] { typeof(EventHandler) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Delegate),
			typeof(Delegate)
		}, ReturnType = typeof(Delegate))]
		public void RemoveHandler(object key, Delegate value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400119A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private EventHandlerList.ListEntry _head;

		[global::Cpp2ILInjected.Token(Token = "0x400119B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Component _parent;

		[global::Cpp2ILInjected.Token(Token = "0x200033A")]
		private sealed class ListEntry
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001595")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E3C724", Offset = "0x1E3C724", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public ListEntry(object key, Delegate handler, EventHandlerList.ListEntry next)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400119C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal EventHandlerList.ListEntry _next;

			[global::Cpp2ILInjected.Token(Token = "0x400119D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal object _key;

			[global::Cpp2ILInjected.Token(Token = "0x400119E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			internal Delegate _handler;
		}
	}
}
