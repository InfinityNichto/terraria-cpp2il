using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine
{
	// Token: 0x0200007B RID: 123
	[global::Cpp2ILInjected.Token(Token = "0x2000088")]
	public struct Ray : IFormattable
	{
		// Token: 0x06000269 RID: 617 RVA: 0x00002521 File Offset: 0x00000721
		[global::Cpp2ILInjected.Token(Token = "0x6000277")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78794", Offset = "0x1F78794", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToRay", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Vector2)
		}, ReturnType = typeof(Ray))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public Ray(Vector3 origin, Vector3 direction)
		{
			throw null;
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x0600026A RID: 618 RVA: 0x00002524 File Offset: 0x00000724
		[global::Cpp2ILInjected.Token(Token = "0x1700008E")]
		public Vector3 origin
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000278")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F777F0", Offset = "0x1F777F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new object[]
			{
				typeof(RectTransform),
				typeof(Vector2),
				typeof(Camera),
				typeof(ref Vector3)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002527 File Offset: 0x00000727
		[global::Cpp2ILInjected.Token(Token = "0x1700008F")]
		public Vector3 direction
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000279")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F777E4", Offset = "0x1F777E4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.GraphicRaycaster", Member = "Raycast", MemberParameters = new object[] { "UnityEngine.EventSystems.PointerEventData", "System.Collections.Generic.List`1<RaycastResult>" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.PhysicsRaycaster", Member = "ComputeRayAndDistance", MemberParameters = new object[]
			{
				"UnityEngine.EventSystems.PointerEventData",
				typeof(ref Ray),
				typeof(ref int),
				typeof(ref float)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "DoSendMouseEvents", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0000252A File Offset: 0x0000072A
		[global::Cpp2ILInjected.Token(Token = "0x600027A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F78880", Offset = "0x1F78880", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "ScreenToLocal", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RectTransformUtility", Member = "ScreenPointToWorldPointInRectangle", MemberParameters = new object[]
		{
			typeof(RectTransform),
			typeof(Vector2),
			typeof(Camera),
			typeof(ref Vector3)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public Vector3 GetPoint(float distance)
		{
			throw null;
		}

		// Token: 0x0600026D RID: 621 RVA: 0x0000252D File Offset: 0x0000072D
		[global::Cpp2ILInjected.Token(Token = "0x600027B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F788A8", Offset = "0x1F788A8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600026E RID: 622 RVA: 0x00002530 File Offset: 0x00000730
		[global::Cpp2ILInjected.Token(Token = "0x600027C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F788B4", Offset = "0x1F788B4", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x040002F4 RID: 756
		[global::Cpp2ILInjected.Token(Token = "0x400031F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Vector3 m_Origin;

		// Token: 0x040002F5 RID: 757
		[global::Cpp2ILInjected.Token(Token = "0x4000320")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		private Vector3 m_Direction;
	}
}
