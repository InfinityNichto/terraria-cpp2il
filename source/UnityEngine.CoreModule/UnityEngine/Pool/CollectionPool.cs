﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Pool
{
	[global::Cpp2ILInjected.Token(Token = "0x2000156")]
	public class CollectionPool<TCollection, TItem> where TCollection : class, ICollection<TItem>, new()
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000668")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EBA00", Offset = "0x18EBA00", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "InitializeListIfRequired", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static TCollection Get()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000669")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EBAC8", Offset = "0x18EBAC8", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.VertexHelper", Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static void Release(TCollection toRelease)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600066A")]
		[global::Cpp2ILInjected.Address(RVA = "0x18EBBA8", Offset = "0x18EBBA8", Length = "0x318")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		static CollectionPool()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000636")]
		internal static readonly ObjectPool<TCollection> s_Pool;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000157")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600066B")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0C44", Offset = "0x15B0C44", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600066C")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0D30", Offset = "0x15B0D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600066D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0D38", Offset = "0x15B0D38", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal TCollection <.cctor>b__5_0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x600066E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0D4C", Offset = "0x15B0D4C", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <.cctor>b__5_1(TCollection l)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x4000637")]
			public static readonly CollectionPool<TCollection, TItem>.<>c <>9;
		}
	}
}
