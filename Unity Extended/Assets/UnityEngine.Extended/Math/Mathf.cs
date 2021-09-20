using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Extended
{
    public struct Mathf
    {
        /// <summary>
        /// Degrees-to-radians conversion constant (Read Only).
        /// </summary>
        public static readonly float Deg2Rad = UnityEngine.Mathf.Deg2Rad;

        /// <summary>
        /// Radians-to-degrees conversion constant (Read Only).
        /// </summary>
        public static readonly float Rad2Deg = UnityEngine.Mathf.Rad2Deg;

        /// <summary>
        /// A tiny floating point value (Read Only).
        /// </summary>
        public static readonly float Epsilon = UnityEngine.Mathf.Epsilon;

        /// <summary>
        /// A representation of positive infinity (Read Only).
        /// </summary>
        public static readonly float Infinity = UnityEngine.Mathf.Infinity;

        /// <summary>
        /// A representation of negative infinity (Read Only).
        /// </summary>
        public static readonly float NegativeInfinity = UnityEngine.Mathf.NegativeInfinity;

        /// <summary>
        /// 2 * PI value (Read Only).
        /// </summary>
        public static readonly float Tau = UnityEngine.Mathf.PI * 2f;

        /// <summary>
        /// The well-known 3.14159265358979... value (Read Only).
        /// </summary>
        public static readonly float Pi = UnityEngine.Mathf.PI;

        /// <summary>
        /// PI / 2 (Read Only).
        /// </summary>
        public static readonly float PiOver2 = UnityEngine.Mathf.PI / 2f;

        /// <summary>
        /// PI / 4 (Read Only).
        /// </summary>
        public static readonly float PiOver4 = UnityEngine.Mathf.PI / 4f;

        /// <summary>
        /// Returns the absolute value of f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Abs(float f) => UnityEngine.Mathf.Abs(f);

        /// <summary>
        /// Returns the arc-cosine of f - the angle in radians whose cosine is f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Acos(float f) => UnityEngine.Mathf.Acos(f);

        /// <summary>
        /// Compares two floating point values and returns true if they are similar.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool Approximately(float a, float b) => UnityEngine.Mathf.Approximately(a, b);

        /// <summary>
        /// Returns the arc-sine of f - the angle in radians whose sine is f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Asin(float f) => UnityEngine.Mathf.Asin(f);

        /// <summary>
        /// Returns the arc-tangent of f - the angle in radians whose tangent is f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Atan(float f) => UnityEngine.Mathf.Atan(f);

        /// <summary>
        /// Returns the angle in radians whose Tan is y/x.
        /// </summary>
        /// <param name="y"></param>
        /// <param name="x"></param>
        /// <returns></returns>
        public static float Atan2(float y, float x) => UnityEngine.Mathf.Atan2(y, x);

        /// <summary>
        /// Returns the smallest integer greater to or equal to f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Ceil(float f) => UnityEngine.Mathf.Ceil(f);

        /// <summary>
        /// Returns the smallest integer greater to or equal to f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static int CeilToInt(float f) => UnityEngine.Mathf.CeilToInt(f);

        /// <summary>
        /// Clamps the given value between the given minimum float and maximum float values. Returns the given value if it is within the min and max range.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static float Clamp(float value, float min, float max) => UnityEngine.Mathf.Clamp(value, min, max);

        /// <summary>
        /// Clamps value between 0 and 1 and returns value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float Clamp01(float value) => UnityEngine.Mathf.Clamp01(value);

        /// <summary>
        /// Returns the closest power of two value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int ClosestPowerOfTwo(int value) => UnityEngine.Mathf.ClosestPowerOfTwo(value);

        /// <summary>
        /// Convert a color temperature in Kelvin to RGB color.
        /// </summary>
        /// <param name="kelvin"></param>
        /// <returns></returns>
        public static Color CorrelatedColorTemperatureToRGB(float kelvin) => UnityEngine.Mathf.CorrelatedColorTemperatureToRGB(kelvin);

        /// <summary>
        /// Returns the cosine of angle f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Cos(float f) => UnityEngine.Mathf.Cos(f);

        /// <summary>
        /// Calculates the shortest difference between two given angles given in degrees.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static float DeltaAngle(float current, float target) => UnityEngine.Mathf.DeltaAngle(current, target);

        /// <summary>
        /// Returns e raised to the specified power.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public static float Exp(float power) => UnityEngine.Mathf.Exp(power);

        /// <summary>
        /// Encode a floating point value into a 16-bit representation.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static ushort FloatToHalf(float val) => UnityEngine.Mathf.FloatToHalf(val);

        /// <summary>
        /// Returns the largest integer smaller than or equal to f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Floor(float f) => UnityEngine.Mathf.Floor(f);

        /// <summary>
        /// Returns the largest integer smaller than or equal to f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float FloorToInt(float f) => UnityEngine.Mathf.FloorToInt(f);

        /// <summary>
        /// Converts the given value from gamma (sRGB) to linear color space.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float GammaToLinearSpace(float value) => UnityEngine.Mathf.GammaToLinearSpace(value);

        /// <summary>
        /// Convert a half precision float to a 32-bit floating point value.
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static float HalfToFloat(ushort val) => UnityEngine.Mathf.HalfToFloat(val);

        /// <summary>
        /// Calculates the linear parameter t that produces the interpolant value within the range [a, b].
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float InverseLerp(float a, float b, float value) => UnityEngine.Mathf.InverseLerp(a, b, value);

        /// <summary>
        /// Returns true if the value is power of two.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsPowerOfTwo(int value) => UnityEngine.Mathf.IsPowerOfTwo(value);

        /// <summary>
        /// Linearly interpolates between a and b by t.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float Lerp(float a, float b, float t) => UnityEngine.Mathf.Lerp(a, b, t);

        /// <summary>
        /// Same as Lerp but makes sure the values interpolate correctly when they wrap around 360 degrees.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float LerpAngle(float a, float b, float t) => UnityEngine.Mathf.LerpAngle(a, b, t);

        /// <summary>
        /// Linearly interpolates between a and b by t with no limit to t.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float LerpUnclamped(float a, float b, float t) => UnityEngine.Mathf.LerpUnclamped(a, b, t);

        /// <summary>
        /// Converts the given value from linear to gamma (sRGB) color space.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static float LinearToGammaSpace(float value) => UnityEngine.Mathf.LinearToGammaSpace(value);

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static float Log(float f, float p) => UnityEngine.Mathf.Log(f, p);

        /// <summary>
        /// Returns the logarithm of a specified number in a specified base.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Log(float f) => UnityEngine.Mathf.Log(f);

        /// <summary>
        /// Returns the base 10 logarithm of a specified number.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Log10(float f) => UnityEngine.Mathf.Log10(f);

        /// <summary>
        /// Returns the base 2 logarithm of a specified number.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Log2(float f) => UnityEngine.Mathf.Log(f, 2.0f);

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Max(float a, float b) => UnityEngine.Mathf.Max(a, b);

        /// <summary>
        /// Returns largest of two or more values.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static float Max(params float[] values) => UnityEngine.Mathf.Max(values);

        /// <summary>
        /// Returns smallest of two or more values.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static float Min(float a, float b) => UnityEngine.Mathf.Min(a, b);

        /// <summary>
        /// Returns smallest of two or more values.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static float Min(params float[] values) => UnityEngine.Mathf.Min(values);

        /// <summary>
        /// Moves a value current towards target.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDelta"></param>
        /// <returns></returns>
        public static float MoveTowards(float current, float target, float maxDelta) => UnityEngine.Mathf.MoveTowards(current, target, maxDelta);

        /// <summary>
        /// Same as MoveTowards but makes sure the values interpolate correctly when they wrap around 360 degrees.
        /// </summary>
        /// <param name="current"></param>
        /// <param name="target"></param>
        /// <param name="maxDelta"></param>
        /// <returns></returns>
        public static float MoveTowardsAngle(float current, float target, float maxDelta) => UnityEngine.Mathf.MoveTowardsAngle(current, target, maxDelta);

        /// <summary>
        /// Returns the next power of two that is equal to, or greater than, the argument.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static int NextPowerOfTwo(int value) => UnityEngine.Mathf.NextPowerOfTwo(value);

        /// <summary>
        /// Generate 2D Perlin noise.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>float Value between 0.0 and 1.0. (Return value might be slightly below 0.0 or beyond 1.0.)</returns>
        public static float PerlinNoise(float x, float y) => UnityEngine.Mathf.PerlinNoise(x, y);

        /// <summary>
        /// Returns a value that will increment and decrement between the value 0 and length.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static float PingPong(float t, float length) => UnityEngine.Mathf.PingPong(t, length);

        /// <summary>
        /// Returns f raised to power p.
        /// </summary>
        /// <param name="f"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static float Pow(float f, float p) => UnityEngine.Mathf.Pow(f, p);

        /// <summary>
        /// Loops the value t, so that it is never larger than length and never smaller than 0.
        /// </summary>
        /// <param name="t"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        public static float Repeat(float t, float length) => UnityEngine.Mathf.Repeat(t, length);

        /// <summary>
        /// Returns f rounded to the nearest integer.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Round(float f) => UnityEngine.Mathf.Round(f);

        /// <summary>
        /// Returns f rounded to the nearest integer.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static int RoundToInt(float f) => UnityEngine.Mathf.RoundToInt(f);

        /// <summary>
        /// Returns the sign of f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Sign(float f) => UnityEngine.Mathf.Sign(f);

        /// <summary>
        /// Returns the sine of angle f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns>float The return value between -1 and +1.</returns>
        public static float Sin(float f) => UnityEngine.Mathf.Sin(f);

        /// <summary>
        /// Gradually changes a value towards a desired goal over time.
        /// </summary>
        /// <param name="current">The current position.</param>
        /// <param name="target">The position we are trying to reach.</param>
        /// <param name="currentVelocity">The current velocity, this value is modified by the function every time you call it.</param>
        /// <param name="smoothTime">Approximately the time it will take to reach the target. A smaller value will reach the target faster.</param>
        /// <returns></returns>
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime) =>
            UnityEngine.Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, Infinity, Time.deltaTime);

        /// <summary>
        /// Gradually changes a value towards a desired goal over time.
        /// </summary>
        /// <param name="current">The current position.</param>
        /// <param name="target">The position we are trying to reach.</param>
        /// <param name="currentVelocity">The current velocity, this value is modified by the function every time you call it.</param>
        /// <param name="smoothTime">Approximately the time it will take to reach the target. A smaller value will reach the target faster.</param>
        /// <param name="maxSpeed">Optionally allows you to clamp the maximum speed.</param>
        /// <returns></returns>
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed) =>
            UnityEngine.Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);

        /// <summary>
        /// Gradually changes a value towards a desired goal over time.
        /// </summary>
        /// <param name="current">The current position.</param>
        /// <param name="target">The position we are trying to reach.</param>
        /// <param name="currentVelocity">The current velocity, this value is modified by the function every time you call it.</param>
        /// <param name="smoothTime">Approximately the time it will take to reach the target. A smaller value will reach the target faster.</param>
        /// <param name="maxSpeed">Optionally allows you to clamp the maximum speed.</param>
        /// <param name="deltaTime">The time since the last call to this function. By default Time.deltaTime.</param>
        /// <returns></returns>
        public static float SmoothDamp(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) =>
            UnityEngine.Mathf.SmoothDamp(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);

        /// <summary>
        /// Gradually changes an angle given in degrees towards a desired goal angle over time.
        /// </summary>
        /// <param name="current">The current position.</param>
        /// <param name="target">The position we are trying to reach.</param>
        /// <param name="currentVelocity">The current velocity, this value is modified by the function every time you call it.</param>
        /// <param name="smoothTime">Approximately the time it will take to reach the target. A smaller value will reach the target faster.</param>
        /// <returns></returns>
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime) =>
            UnityEngine.Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, Infinity, Time.deltaTime);

        /// <summary>
        /// Gradually changes a value towards a desired goal over time.
        /// </summary>
        /// <param name="current">The current position.</param>
        /// <param name="target">The position we are trying to reach.</param>
        /// <param name="currentVelocity">The current velocity, this value is modified by the function every time you call it.</param>
        /// <param name="smoothTime">Approximately the time it will take to reach the target. A smaller value will reach the target faster.</param>
        /// <param name="maxSpeed">Optionally allows you to clamp the maximum speed.</param>
        /// <returns></returns>
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed) =>
            UnityEngine.Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, Time.deltaTime);

        /// <summary>
        /// Gradually changes a value towards a desired goal over time.
        /// </summary>
        /// <param name="current">The current position.</param>
        /// <param name="target">The position we are trying to reach.</param>
        /// <param name="currentVelocity">The current velocity, this value is modified by the function every time you call it.</param>
        /// <param name="smoothTime">Approximately the time it will take to reach the target. A smaller value will reach the target faster.</param>
        /// <param name="maxSpeed">Optionally allows you to clamp the maximum speed.</param>
        /// <param name="deltaTime">The time since the last call to this function. By default Time.deltaTime.</param>
        /// <returns></returns>
        public static float SmoothDampAngle(float current, float target, ref float currentVelocity, float smoothTime, float maxSpeed, float deltaTime) =>
            UnityEngine.Mathf.SmoothDampAngle(current, target, ref currentVelocity, smoothTime, maxSpeed, deltaTime);

        /// <summary>
        /// Interpolates between min and max with smoothing at the limits.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <param name="t"></param>
        /// <returns></returns>
        public static float SmoothStep(float from, float to, float t) => UnityEngine.Mathf.SmoothStep(from, to, t);

        /// <summary>
        /// Returns square root of f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Sqrt(float f) => UnityEngine.Mathf.Sqrt(f);

        /// <summary>
        /// Returns 1 / square root of f.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float InverseSqrt(float f) => 1f / UnityEngine.Mathf.Sqrt(f);

        /// <summary>
        /// Returns the tangent of angle f in radians.
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public static float Tan(float f) => UnityEngine.Mathf.Tan(f);
    }
}