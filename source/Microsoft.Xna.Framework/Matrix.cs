using System;
using Cpp2IlInjected;

namespace Microsoft.Xna.Framework;

[Serializable]
[Cpp2IlInjected.Token(Token = "0x200026C")]
public struct Matrix : IEquatable<Matrix>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4001C80")]
	public float M11;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4001C81")]
	public float M12;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4001C82")]
	public float M13;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4001C83")]
	public float M14;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4001C84")]
	public float M21;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4001C85")]
	public float M22;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4001C86")]
	public float M23;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4001C87")]
	public float M24;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4001C88")]
	public float M31;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001C89")]
	public float M32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001C8A")]
	public float M33;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001C8B")]
	public float M34;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001C8C")]
	public float M41;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001C8D")]
	public float M42;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001C8E")]
	public float M43;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001C8F")]
	public float M44;

	[Cpp2IlInjected.Token(Token = "0x4001C90")]
	private static Matrix identity;

	[Cpp2IlInjected.Token(Token = "0x170001B1")]
	public static Matrix Identity
	{
		[Cpp2IlInjected.Token(Token = "0x6001184")]
		[Cpp2IlInjected.Address(RVA = "0x157BD74", Offset = "0x157BD74", VA = "0x157BD74")]
		get
		{
			return default(Matrix);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B2")]
	public Vector3 Backward
	{
		[Cpp2IlInjected.Token(Token = "0x6001185")]
		[Cpp2IlInjected.Address(RVA = "0x3A22D0", Offset = "0x3A22D0", VA = "0x3A22D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6001186")]
		[Cpp2IlInjected.Address(RVA = "0x3A230C", Offset = "0x3A230C", VA = "0x3A230C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B3")]
	public Vector3 Down
	{
		[Cpp2IlInjected.Token(Token = "0x6001187")]
		[Cpp2IlInjected.Address(RVA = "0x3A2318", Offset = "0x3A2318", VA = "0x3A2318")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6001188")]
		[Cpp2IlInjected.Address(RVA = "0x3A2358", Offset = "0x3A2358", VA = "0x3A2358")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B4")]
	public Vector3 Forward
	{
		[Cpp2IlInjected.Token(Token = "0x6001189")]
		[Cpp2IlInjected.Address(RVA = "0x3A2370", Offset = "0x3A2370", VA = "0x3A2370")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600118A")]
		[Cpp2IlInjected.Address(RVA = "0x3A23B0", Offset = "0x3A23B0", VA = "0x3A23B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B5")]
	public Vector3 Left
	{
		[Cpp2IlInjected.Token(Token = "0x600118B")]
		[Cpp2IlInjected.Address(RVA = "0x3A23C8", Offset = "0x3A23C8", VA = "0x3A23C8")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600118C")]
		[Cpp2IlInjected.Address(RVA = "0x3A2408", Offset = "0x3A2408", VA = "0x3A2408")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B6")]
	public Vector3 Right
	{
		[Cpp2IlInjected.Token(Token = "0x600118D")]
		[Cpp2IlInjected.Address(RVA = "0x3A2420", Offset = "0x3A2420", VA = "0x3A2420")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600118E")]
		[Cpp2IlInjected.Address(RVA = "0x3A245C", Offset = "0x3A245C", VA = "0x3A245C")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B7")]
	public Vector3 Translation
	{
		[Cpp2IlInjected.Token(Token = "0x600118F")]
		[Cpp2IlInjected.Address(RVA = "0x3A2468", Offset = "0x3A2468", VA = "0x3A2468")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6001190")]
		[Cpp2IlInjected.Address(RVA = "0x3A24A4", Offset = "0x3A24A4", VA = "0x3A24A4")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170001B8")]
	public Vector3 Up
	{
		[Cpp2IlInjected.Token(Token = "0x6001191")]
		[Cpp2IlInjected.Address(RVA = "0x3A24B0", Offset = "0x3A24B0", VA = "0x3A24B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6001192")]
		[Cpp2IlInjected.Address(RVA = "0x3A24EC", Offset = "0x3A24EC", VA = "0x3A24EC")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6001193")]
	[Cpp2IlInjected.Address(RVA = "0x3A24F8", Offset = "0x3A24F8", VA = "0x3A24F8")]
	public Matrix(float m11, float m12, float m13, float m14, float m21, float m22, float m23, float m24, float m31, float m32, float m33, float m34, float m41, float m42, float m43, float m44)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001194")]
	[Cpp2IlInjected.Address(RVA = "0x157C08C", Offset = "0x157C08C", VA = "0x157C08C")]
	public static Matrix CreateWorld(Vector3 position, Vector3 forward, Vector3 up)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x6001195")]
	[Cpp2IlInjected.Address(RVA = "0x157C188", Offset = "0x157C188", VA = "0x157C188")]
	public static void CreateWorld(ref Vector3 position, ref Vector3 forward, ref Vector3 up, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001196")]
	[Cpp2IlInjected.Address(RVA = "0x157C2FC", Offset = "0x157C2FC", VA = "0x157C2FC")]
	public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x6001197")]
	[Cpp2IlInjected.Address(RVA = "0x157C3E8", Offset = "0x157C3E8", VA = "0x157C3E8")]
	public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001198")]
	[Cpp2IlInjected.Address(RVA = "0x157C5F0", Offset = "0x157C5F0", VA = "0x157C5F0")]
	public static void CreateReflection(ref Plane value, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6001199")]
	[Cpp2IlInjected.Address(RVA = "0x157C6D8", Offset = "0x157C6D8", VA = "0x157C6D8")]
	public static Matrix CreateReflection(Plane value)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x600119A")]
	[Cpp2IlInjected.Address(RVA = "0x157C7B0", Offset = "0x157C7B0", VA = "0x157C7B0")]
	public static Matrix CreateFromYawPitchRoll(float yaw, float pitch, float roll)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x600119B")]
	[Cpp2IlInjected.Address(RVA = "0x157CDE0", Offset = "0x157CDE0", VA = "0x157CDE0")]
	public static void CreateFromYawPitchRoll(float yaw, float pitch, float roll, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600119C")]
	[Cpp2IlInjected.Address(RVA = "0x157CEBC", Offset = "0x157CEBC", VA = "0x157CEBC")]
	public static void Transform(ref Matrix value, ref Quaternion rotation, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600119D")]
	[Cpp2IlInjected.Address(RVA = "0x157D3B4", Offset = "0x157D3B4", VA = "0x157D3B4")]
	public static Matrix Transform(Matrix value, Quaternion rotation)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x600119E")]
	[Cpp2IlInjected.Address(RVA = "0x3A256C", Offset = "0x3A256C", VA = "0x3A256C")]
	public bool Decompose(out Vector3 scale, out Quaternion rotation, out Vector3 translation)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600119F")]
	[Cpp2IlInjected.Address(RVA = "0x157DD00", Offset = "0x157DD00", VA = "0x157DD00")]
	public static Matrix Add(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011A0")]
	[Cpp2IlInjected.Address(RVA = "0x157DE14", Offset = "0x157DE14", VA = "0x157DE14")]
	public static void Add(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011A1")]
	[Cpp2IlInjected.Address(RVA = "0x157DF18", Offset = "0x157DF18", VA = "0x157DF18")]
	public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011A2")]
	[Cpp2IlInjected.Address(RVA = "0x157E014", Offset = "0x157E014", VA = "0x157E014")]
	public static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Vector3? cameraForwardVector, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011A3")]
	[Cpp2IlInjected.Address(RVA = "0x157E230", Offset = "0x157E230", VA = "0x157E230")]
	public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011A4")]
	[Cpp2IlInjected.Address(RVA = "0x157E2A8", Offset = "0x157E2A8", VA = "0x157E2A8")]
	public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011A5")]
	[Cpp2IlInjected.Address(RVA = "0x157E320", Offset = "0x157E320", VA = "0x157E320")]
	public static Matrix CreateFromAxisAngle(Vector3 axis, float angle)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011A6")]
	[Cpp2IlInjected.Address(RVA = "0x157E398", Offset = "0x157E398", VA = "0x157E398")]
	public static void CreateFromAxisAngle(ref Vector3 axis, float angle, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011A7")]
	[Cpp2IlInjected.Address(RVA = "0x157CF98", Offset = "0x157CF98", VA = "0x157CF98")]
	public static Matrix CreateFromQuaternion(Quaternion quaternion)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011A8")]
	[Cpp2IlInjected.Address(RVA = "0x157CBEC", Offset = "0x157CBEC", VA = "0x157CBEC")]
	public static void CreateFromQuaternion(ref Quaternion quaternion, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011A9")]
	[Cpp2IlInjected.Address(RVA = "0x157E410", Offset = "0x157E410", VA = "0x157E410")]
	public static Matrix CreateLookAt(Vector3 cameraPosition, Vector3 cameraTarget, Vector3 cameraUpVector)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011AA")]
	[Cpp2IlInjected.Address(RVA = "0x157E50C", Offset = "0x157E50C", VA = "0x157E50C")]
	public static void CreateLookAt(ref Vector3 cameraPosition, ref Vector3 cameraTarget, ref Vector3 cameraUpVector, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011AB")]
	[Cpp2IlInjected.Address(RVA = "0x157E794", Offset = "0x157E794", VA = "0x157E794")]
	public static Matrix CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011AC")]
	[Cpp2IlInjected.Address(RVA = "0x157E880", Offset = "0x157E880", VA = "0x157E880")]
	public static void CreateOrthographic(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011AD")]
	[Cpp2IlInjected.Address(RVA = "0x157E8F0", Offset = "0x157E8F0", VA = "0x157E8F0")]
	public static Matrix CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011AE")]
	[Cpp2IlInjected.Address(RVA = "0x157EA04", Offset = "0x157EA04", VA = "0x157EA04")]
	public static void CreateOrthographicOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011AF")]
	[Cpp2IlInjected.Address(RVA = "0x157EA9C", Offset = "0x157EA9C", VA = "0x157EA9C")]
	public static Matrix CreatePerspective(float width, float height, float zNearPlane, float zFarPlane)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011B0")]
	[Cpp2IlInjected.Address(RVA = "0x157EB14", Offset = "0x157EB14", VA = "0x157EB14")]
	public static void CreatePerspective(float width, float height, float zNearPlane, float zFarPlane, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011B1")]
	[Cpp2IlInjected.Address(RVA = "0x157EB8C", Offset = "0x157EB8C", VA = "0x157EB8C")]
	public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011B2")]
	[Cpp2IlInjected.Address(RVA = "0x157EC74", Offset = "0x157EC74", VA = "0x157EC74")]
	public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011B3")]
	[Cpp2IlInjected.Address(RVA = "0x157EECC", Offset = "0x157EECC", VA = "0x157EECC")]
	public static Matrix CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float zNearPlane, float zFarPlane)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011B4")]
	[Cpp2IlInjected.Address(RVA = "0x157EF44", Offset = "0x157EF44", VA = "0x157EF44")]
	public static void CreatePerspectiveOffCenter(float left, float right, float bottom, float top, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011B5")]
	[Cpp2IlInjected.Address(RVA = "0x157EFBC", Offset = "0x157EFBC", VA = "0x157EFBC")]
	public static Matrix CreateRotationX(float radians)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011B6")]
	[Cpp2IlInjected.Address(RVA = "0x157F1C4", Offset = "0x157F1C4", VA = "0x157F1C4")]
	public static void CreateRotationX(float radians, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011B7")]
	[Cpp2IlInjected.Address(RVA = "0x157F320", Offset = "0x157F320", VA = "0x157F320")]
	public static Matrix CreateRotationY(float radians)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011B8")]
	[Cpp2IlInjected.Address(RVA = "0x157F50C", Offset = "0x157F50C", VA = "0x157F50C")]
	public static void CreateRotationY(float radians, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011B9")]
	[Cpp2IlInjected.Address(RVA = "0x157F668", Offset = "0x157F668", VA = "0x157F668")]
	public static Matrix CreateRotationZ(float radians)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011BA")]
	[Cpp2IlInjected.Address(RVA = "0x157F838", Offset = "0x157F838", VA = "0x157F838")]
	public static void CreateRotationZ(float radians, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011BB")]
	[Cpp2IlInjected.Address(RVA = "0x157F994", Offset = "0x157F994", VA = "0x157F994")]
	public static Matrix CreateScale(float scale)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011BC")]
	[Cpp2IlInjected.Address(RVA = "0x157FAB4", Offset = "0x157FAB4", VA = "0x157FAB4")]
	public static void CreateScale(float scale, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011BD")]
	[Cpp2IlInjected.Address(RVA = "0x157FBA8", Offset = "0x157FBA8", VA = "0x157FBA8")]
	public static Matrix CreateScale(float xScale, float yScale, float zScale)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011BE")]
	[Cpp2IlInjected.Address(RVA = "0x157FCD8", Offset = "0x157FCD8", VA = "0x157FCD8")]
	public static void CreateScale(float xScale, float yScale, float zScale, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011BF")]
	[Cpp2IlInjected.Address(RVA = "0x157FDDC", Offset = "0x157FDDC", VA = "0x157FDDC")]
	public static Matrix CreateScale(Vector3 scales)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011C0")]
	[Cpp2IlInjected.Address(RVA = "0x157FEF8", Offset = "0x157FEF8", VA = "0x157FEF8")]
	public static void CreateScale(ref Vector3 scales, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011C1")]
	[Cpp2IlInjected.Address(RVA = "0x157FFEC", Offset = "0x157FFEC", VA = "0x157FFEC")]
	public static Matrix CreateTranslation(float xPosition, float yPosition, float zPosition)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011C2")]
	[Cpp2IlInjected.Address(RVA = "0x1580108", Offset = "0x1580108", VA = "0x1580108")]
	public static void CreateTranslation(float xPosition, float yPosition, float zPosition, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011C3")]
	[Cpp2IlInjected.Address(RVA = "0x158020C", Offset = "0x158020C", VA = "0x158020C")]
	public static Matrix CreateTranslation(Vector3 position)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011C4")]
	[Cpp2IlInjected.Address(RVA = "0x1580314", Offset = "0x1580314", VA = "0x1580314")]
	public static void CreateTranslation(ref Vector3 position, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011C5")]
	[Cpp2IlInjected.Address(RVA = "0x1580408", Offset = "0x1580408", VA = "0x1580408")]
	public static Matrix Divide(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011C6")]
	[Cpp2IlInjected.Address(RVA = "0x1580720", Offset = "0x1580720", VA = "0x1580720")]
	public static void Divide(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011C7")]
	[Cpp2IlInjected.Address(RVA = "0x1580AE8", Offset = "0x1580AE8", VA = "0x1580AE8")]
	public static Matrix Divide(Matrix matrix1, float divider)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011C8")]
	[Cpp2IlInjected.Address(RVA = "0x1580BC8", Offset = "0x1580BC8", VA = "0x1580BC8")]
	public static void Divide(ref Matrix matrix1, float divider, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011C9")]
	[Cpp2IlInjected.Address(RVA = "0x1580620", Offset = "0x1580620", VA = "0x1580620")]
	public static Matrix Invert(Matrix matrix)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011CA")]
	[Cpp2IlInjected.Address(RVA = "0x1580C98", Offset = "0x1580C98", VA = "0x1580C98")]
	public static void Invert(ref Matrix matrix, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011CB")]
	[Cpp2IlInjected.Address(RVA = "0x1580EE0", Offset = "0x1580EE0", VA = "0x1580EE0")]
	public static Matrix Lerp(Matrix matrix1, Matrix matrix2, float amount)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011CC")]
	[Cpp2IlInjected.Address(RVA = "0x1580F58", Offset = "0x1580F58", VA = "0x1580F58")]
	public static void Lerp(ref Matrix matrix1, ref Matrix matrix2, float amount, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011CD")]
	[Cpp2IlInjected.Address(RVA = "0x1580FD0", Offset = "0x1580FD0", VA = "0x1580FD0")]
	public static Matrix Multiply(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011CE")]
	[Cpp2IlInjected.Address(RVA = "0x157D070", Offset = "0x157D070", VA = "0x157D070")]
	public static void Multiply(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011CF")]
	[Cpp2IlInjected.Address(RVA = "0x15811A8", Offset = "0x15811A8", VA = "0x15811A8")]
	public static Matrix Multiply(Matrix matrix1, float factor)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011D0")]
	[Cpp2IlInjected.Address(RVA = "0x1581280", Offset = "0x1581280", VA = "0x1581280")]
	public static void Multiply(ref Matrix matrix1, float factor, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011D1")]
	[Cpp2IlInjected.Address(RVA = "0x1581348", Offset = "0x1581348", VA = "0x1581348")]
	public static Matrix Negate(Matrix matrix)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011D2")]
	[Cpp2IlInjected.Address(RVA = "0x1581404", Offset = "0x1581404", VA = "0x1581404")]
	public static void Negate(ref Matrix matrix, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011D3")]
	[Cpp2IlInjected.Address(RVA = "0x1581488", Offset = "0x1581488", VA = "0x1581488")]
	public static Matrix Subtract(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011D4")]
	[Cpp2IlInjected.Address(RVA = "0x158159C", Offset = "0x158159C", VA = "0x158159C")]
	public static void Subtract(ref Matrix matrix1, ref Matrix matrix2, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011D5")]
	[Cpp2IlInjected.Address(RVA = "0x15816A0", Offset = "0x15816A0", VA = "0x15816A0")]
	public static Matrix Transpose(Matrix matrix)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011D6")]
	[Cpp2IlInjected.Address(RVA = "0x1581718", Offset = "0x1581718", VA = "0x1581718")]
	public static void Transpose(ref Matrix matrix, out Matrix result)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60011D7")]
	[Cpp2IlInjected.Address(RVA = "0x3A2588", Offset = "0x3A2588", VA = "0x3A2588")]
	public float Determinant()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60011D8")]
	[Cpp2IlInjected.Address(RVA = "0x3A2590", Offset = "0x3A2590", VA = "0x3A2590", Slot = "4")]
	public bool Equals(Matrix other)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011D9")]
	[Cpp2IlInjected.Address(RVA = "0x15819D8", Offset = "0x15819D8", VA = "0x15819D8")]
	public static Matrix operator +(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011DA")]
	[Cpp2IlInjected.Address(RVA = "0x1581AEC", Offset = "0x1581AEC", VA = "0x1581AEC")]
	public static Matrix operator /(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011DB")]
	[Cpp2IlInjected.Address(RVA = "0x1581D04", Offset = "0x1581D04", VA = "0x1581D04")]
	public static Matrix operator /(Matrix matrix1, float divider)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011DC")]
	[Cpp2IlInjected.Address(RVA = "0x1581DE4", Offset = "0x1581DE4", VA = "0x1581DE4")]
	public static bool operator ==(Matrix matrix1, Matrix matrix2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011DD")]
	[Cpp2IlInjected.Address(RVA = "0x1581FA0", Offset = "0x1581FA0", VA = "0x1581FA0")]
	public static bool operator !=(Matrix matrix1, Matrix matrix2)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011DE")]
	[Cpp2IlInjected.Address(RVA = "0x158215C", Offset = "0x158215C", VA = "0x158215C")]
	public static Matrix operator *(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011DF")]
	[Cpp2IlInjected.Address(RVA = "0x1582334", Offset = "0x1582334", VA = "0x1582334")]
	public static Matrix operator *(Matrix matrix, float scaleFactor)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011E0")]
	[Cpp2IlInjected.Address(RVA = "0x158240C", Offset = "0x158240C", VA = "0x158240C")]
	public static Matrix operator *(float scaleFactor, Matrix matrix)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011E1")]
	[Cpp2IlInjected.Address(RVA = "0x15824E4", Offset = "0x15824E4", VA = "0x15824E4")]
	public static Matrix operator -(Matrix matrix1, Matrix matrix2)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011E2")]
	[Cpp2IlInjected.Address(RVA = "0x15825F8", Offset = "0x15825F8", VA = "0x15825F8")]
	public static Matrix operator -(Matrix matrix)
	{
		return default(Matrix);
	}

	[Cpp2IlInjected.Token(Token = "0x60011E3")]
	[Cpp2IlInjected.Address(RVA = "0x3A2604", Offset = "0x3A2604", VA = "0x3A2604", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60011E4")]
	[Cpp2IlInjected.Address(RVA = "0x3A260C", Offset = "0x3A260C", VA = "0x3A260C", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60011E5")]
	[Cpp2IlInjected.Address(RVA = "0x3A2618", Offset = "0x3A2618", VA = "0x3A2618", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
