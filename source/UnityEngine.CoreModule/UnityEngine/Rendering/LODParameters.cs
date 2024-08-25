using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering
{
	[global::Cpp2ILInjected.Token(Token = "0x2000112")]
	public struct LODParameters : IEquatable<LODParameters>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000580")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B544", Offset = "0x1F8B544", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LODParameters), Member = "Equals", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Equals", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(bool))]
		public bool Equals(LODParameters other)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000581")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B5E0", Offset = "0x1F8B5E0", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LODParameters), Member = "Equals", MemberParameters = new object[] { typeof(LODParameters) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000582")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8B670", Offset = "0x1F8B670", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400048B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private int m_IsOrthographic;

		[global::Cpp2ILInjected.Token(Token = "0x400048C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		private Vector3 m_CameraPosition;

		[global::Cpp2ILInjected.Token(Token = "0x400048D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private float m_FieldOfView;

		[global::Cpp2ILInjected.Token(Token = "0x400048E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private float m_OrthoSize;

		[global::Cpp2ILInjected.Token(Token = "0x400048F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int m_CameraPixelHeight;
	}
}
