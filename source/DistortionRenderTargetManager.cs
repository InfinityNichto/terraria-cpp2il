using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent.Shaders;
using UnityEngine;

// Token: 0x0200024A RID: 586
[global::Cpp2ILInjected.Token(Token = "0x2000304")]
public class DistortionRenderTargetManager : MonoBehaviour
{
	// Token: 0x1700017B RID: 379
	// (get) Token: 0x06001093 RID: 4243 RVA: 0x00024C9B File Offset: 0x00022E9B
	[global::Cpp2ILInjected.Token(Token = "0x170001A3")]
	public static DistortionRenderTargetManager Instance
	{
		[global::Cpp2ILInjected.Token(Token = "0x60011E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xA70DC4", Offset = "0xA70DC4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "PreDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "Apply", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
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

	// Token: 0x06001094 RID: 4244 RVA: 0x00024C9E File Offset: 0x00022E9E
	[global::Cpp2ILInjected.Token(Token = "0x60011E5")]
	[global::Cpp2ILInjected.Address(RVA = "0xA70EB4", Offset = "0xA70EB4", Length = "0x2D8")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "SwapTargets", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "BeginRenderTarget", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		typeof(RenderTextureFormat),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Texture), Member = "set_filterMode", MemberParameters = new object[] { typeof(FilterMode) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_targetTexture", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = ".ctor", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "set_position", MemberParameters = new object[] { typeof(global::UnityEngine.Vector3) }, ReturnType = typeof(void))]
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
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
	private void InitialiseCamera()
	{
		throw null;
	}

	// Token: 0x06001095 RID: 4245 RVA: 0x00024CA1 File Offset: 0x00022EA1
	[global::Cpp2ILInjected.Token(Token = "0x60011E6")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7122C", Offset = "0xA7122C", Length = "0x20")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "PreDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "BeginRenderTarget", MemberParameters = new object[]
	{
		typeof(bool),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "EndRenderTarget", ReturnType = typeof(void))]
	public void ClearRenderTarget()
	{
		throw null;
	}

	// Token: 0x06001096 RID: 4246 RVA: 0x00024CA4 File Offset: 0x00022EA4
	[global::Cpp2ILInjected.Token(Token = "0x60011E7")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7139C", Offset = "0xA7139C", Length = "0x8C")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_targetTexture", MemberParameters = new object[] { typeof(RenderTexture) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void SwapTargets()
	{
		throw null;
	}

	// Token: 0x06001097 RID: 4247 RVA: 0x00024CA7 File Offset: 0x00022EA7
	[global::Cpp2ILInjected.Token(Token = "0x60011E8")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7124C", Offset = "0xA7124C", Length = "0xF0")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "ClearRenderTarget", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
	{
		typeof(global::UnityEngine.Object),
		typeof(global::UnityEngine.Object)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DistortionRenderTargetManager), Member = "InitialiseCamera", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_backgroundColor", MemberParameters = new object[] { typeof(global::UnityEngine.Color) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "set_clearFlags", MemberParameters = new object[] { typeof(CameraClearFlags) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "BeginBuffer", MemberParameters = new object[]
	{
		typeof(GeometryBufferInstance.BatchBuffer),
		typeof(int)
	}, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
	public void BeginRenderTarget(bool clear, float clearValue)
	{
		throw null;
	}

	// Token: 0x06001098 RID: 4248 RVA: 0x00024CAA File Offset: 0x00022EAA
	[global::Cpp2ILInjected.Token(Token = "0x60011E9")]
	[global::Cpp2ILInjected.Address(RVA = "0xA7133C", Offset = "0xA7133C", Length = "0x60")]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DistortionRenderTargetManager), Member = "ClearRenderTarget", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GeometryBufferInstance), Member = "EndBuffer", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = "Render", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
	public void EndRenderTarget()
	{
		throw null;
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x00024CAD File Offset: 0x00022EAD
	[global::Cpp2ILInjected.Token(Token = "0x60011EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xA71428", Offset = "0xA71428", Length = "0x8")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
	public DistortionRenderTargetManager()
	{
		throw null;
	}

	// Token: 0x04001BB0 RID: 7088
	[global::Cpp2ILInjected.Token(Token = "0x400216A")]
	public static DistortionRenderTargetManager _instance;

	// Token: 0x04001BB1 RID: 7089
	[global::Cpp2ILInjected.Token(Token = "0x400216B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	private Camera cameraObject;

	// Token: 0x04001BB2 RID: 7090
	[global::Cpp2ILInjected.Token(Token = "0x400216C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public RenderTexture DistortionTarget;

	// Token: 0x04001BB3 RID: 7091
	[global::Cpp2ILInjected.Token(Token = "0x400216D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public RenderTexture DistortionTargetSwap;

	// Token: 0x04001BB4 RID: 7092
	[global::Cpp2ILInjected.Token(Token = "0x400216E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTarget;

	// Token: 0x04001BB5 RID: 7093
	[global::Cpp2ILInjected.Token(Token = "0x400216F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Microsoft.Xna.Framework.Graphics.Texture2D GameDistortionTargetSwap;
}
