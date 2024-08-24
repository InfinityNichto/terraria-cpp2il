﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Initializers;

namespace Microsoft.Xna.Framework
{
	// Token: 0x02000273 RID: 627
	[global::Cpp2ILInjected.Token(Token = "0x2000334")]
	public class GameServiceContainer : IServiceProvider
	{
		// Token: 0x06001335 RID: 4917 RVA: 0x0002546C File Offset: 0x0002366C
		[global::Cpp2ILInjected.Token(Token = "0x6001492")]
		[global::Cpp2ILInjected.Address(RVA = "0xA94D14", Offset = "0xA94D14", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Game), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public GameServiceContainer()
		{
			throw null;
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x0002546F File Offset: 0x0002366F
		[global::Cpp2ILInjected.Token(Token = "0x6001493")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95EF0", Offset = "0xA95EF0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "CreateAssetServices", MemberParameters = new object[] { typeof(GameServiceContainer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddService(Type type, object provider)
		{
			throw null;
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00025472 File Offset: 0x00023672
		[global::Cpp2ILInjected.Token(Token = "0x6001494")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95F50", Offset = "0xA95F50", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public object GetService(Type type)
		{
			throw null;
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00025475 File Offset: 0x00023675
		[global::Cpp2ILInjected.Token(Token = "0x6001495")]
		[global::Cpp2ILInjected.Address(RVA = "0xA95FC0", Offset = "0xA95FC0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RemoveService(Type type)
		{
			throw null;
		}

		// Token: 0x04001CD3 RID: 7379
		[global::Cpp2ILInjected.Token(Token = "0x40022AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Dictionary<Type, object> services;
	}
}