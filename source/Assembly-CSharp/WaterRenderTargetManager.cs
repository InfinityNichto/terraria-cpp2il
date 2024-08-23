using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Shaders;
using UnityEngine;

// Token: 0x0200024E RID: 590
[global::Cpp2ILInjected.Token(Token = "0x2000309")]
public class WaterRenderTargetManager : MonoBehaviour
{
	// Token: 0x17000188 RID: 392
	// (get) Token: 0x060010B5 RID: 4277 RVA: 0x00024D01 File Offset: 0x00022F01
	[global::Cpp2ILInjected.Token(Token = "0x170001B0")]
	public static WaterRenderTargetManager Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001206")]
		[global::Cpp2ILInjected.Address(RVA = "0xA72550", Offset = "0xA72550", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "Find", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObjectExtensions), Member = "FindInChildren", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(string)
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		get
		{
			throw null;
		}
	}

	// Token: 0x060010B6 RID: 4278 RVA: 0x00024D04 File Offset: 0x00022F04
	[global::Cpp2ILInjected.Token(Token = "0x6001207")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72640", Offset = "0xA72640", Length = "0x2A8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterRenderTargetManager), Member = "UpdateRenderTarget", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_gameObject", ReturnType = typeof(GameObject))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldWidth", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(XNAWorldCameraSettings), Member = "get_MaxWorldHeight", ReturnType = typeof(int))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RenderTexture), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(RenderTextureFormat)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_targetTexture", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Matrix4x4), Member = "Ortho", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(Matrix4x4))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_projectionMatrix", MemberParameters = new object[] { typeof(Matrix4x4) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	private void InitialiseCamera()
	{
		throw null;
	}

	// Token: 0x060010B7 RID: 4279 RVA: 0x00024D07 File Offset: 0x00022F07
	[global::Cpp2ILInjected.Token(Token = "0x6001208")]
	[global::Cpp2ILInjected.Address(RVA = "0xA728E8", Offset = "0xA728E8", Length = "0x78")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "Render", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void UpdateRenderTarget()
	{
		throw null;
	}

	// Token: 0x060010B8 RID: 4280 RVA: 0x00024D0A File Offset: 0x00022F0A
	[global::Cpp2ILInjected.Token(Token = "0x6001209")]
	[global::Cpp2ILInjected.Address(RVA = "0xA72960", Offset = "0xA72960", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public WaterRenderTargetManager()
	{
		throw null;
	}

	// Token: 0x04001BD3 RID: 7123
	[global::Cpp2ILInjected.Token(Token = "0x4002191")]
	public static WaterRenderTargetManager _instance;

	// Token: 0x04001BD4 RID: 7124
	[global::Cpp2ILInjected.Token(Token = "0x4002192")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Camera cameraObject;

	// Token: 0x04001BD5 RID: 7125
	[global::Cpp2ILInjected.Token(Token = "0x4002193")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public RenderTexture RenderTarget;

	// Token: 0x04001BD6 RID: 7126
	[global::Cpp2ILInjected.Token(Token = "0x4002194")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameRenderTarget;
}
