using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Terraria.IO;
using UnityEngine;

namespace Terraria.WorldBuilding
{
	// Token: 0x0200036B RID: 875
	[global::Cpp2ILInjected.Token(Token = "0x20004EB")]
	public class WorldGenConfiguration : GameConfiguration
	{
		// Token: 0x06002C75 RID: 11381 RVA: 0x00029F84 File Offset: 0x00028184
		[global::Cpp2ILInjected.Token(Token = "0x6003083")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE208", Offset = "0x12FE208", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenConfiguration), Member = "FromEmbeddedPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(WorldGenConfiguration))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameConfiguration), Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(JToken))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public WorldGenConfiguration(JObject configurationRoot)
		{
			throw null;
		}

		// Token: 0x06002C76 RID: 11382 RVA: 0x00029F87 File Offset: 0x00028187
		[global::Cpp2ILInjected.Token(Token = "0x6003084")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A46B4", Offset = "0x15A46B4", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_1", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_18", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_21", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_22", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_46", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_58", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen.<>c", Member = "<GenerateWorld>b__277_100", MemberParameters = new object[]
		{
			typeof(GenerationProgress),
			typeof(GameConfiguration)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public T CreateBiome<T>() where T : MicroBiome, new()
		{
			throw null;
		}

		// Token: 0x06002C77 RID: 11383 RVA: 0x00029F8A File Offset: 0x0002818A
		[global::Cpp2ILInjected.Token(Token = "0x6003085")]
		[global::Cpp2ILInjected.Address(RVA = "0x15A4744", Offset = "0x15A4744", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref JToken)
		}, ReturnType = typeof(bool))]
		public T CreateBiome<T>(string name) where T : MicroBiome, new()
		{
			throw null;
		}

		// Token: 0x06002C78 RID: 11384 RVA: 0x00029F8D File Offset: 0x0002818D
		[global::Cpp2ILInjected.Token(Token = "0x6003086")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE354", Offset = "0x12FE354", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGenerator), Member = "GenerateWorld", MemberParameters = new object[] { typeof(GenerationProgress) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref JToken)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameConfiguration), Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public GameConfiguration GetPassConfiguration(string name)
		{
			throw null;
		}

		// Token: 0x06002C79 RID: 11385 RVA: 0x00029F90 File Offset: 0x00028190
		[global::Cpp2ILInjected.Token(Token = "0x6003087")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE450", Offset = "0x12FE450", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TextAsset), Member = "get_text", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void LoadOnMainThread(object nullObject)
		{
			throw null;
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00029F93 File Offset: 0x00028193
		[global::Cpp2ILInjected.Token(Token = "0x6003088")]
		[global::Cpp2ILInjected.Address(RVA = "0x12FE4DC", Offset = "0x12FE4DC", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GenerateWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(GenerationProgress)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution.ExecutionSnippet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MainThreadExecution), Member = "ExecuteOnMainThread", MemberParameters = new object[]
		{
			typeof(MainThreadExecution.ExecutionSnippet),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(JsonConvert[]), Member = "DeserializeObject", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGenConfiguration), Member = ".ctor", MemberParameters = new object[] { typeof(JObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static WorldGenConfiguration FromEmbeddedPath(string path)
		{
			throw null;
		}

		// Token: 0x04003175 RID: 12661
		[global::Cpp2ILInjected.Token(Token = "0x4003A93")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly JObject _biomeRoot;

		// Token: 0x04003176 RID: 12662
		[global::Cpp2ILInjected.Token(Token = "0x4003A94")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly JObject _passRoot;

		// Token: 0x04003177 RID: 12663
		[global::Cpp2ILInjected.Token(Token = "0x4003A95")]
		private static string resource;
	}
}
