using System;
using Tweenables.Core;
using Tweenables.Utils;
using UnityEngine;

namespace Tweenables
{
    public static class TweenExtensions
    {
        public static Tween<RawTransform> TweenTransform(this MonoBehaviour owner, Transform target)
        {
            return new Tween<RawTransform>(owner).Use(t => t.Transfer(target, false)).From(new(target, false));
        }

        public static Tween<RawTransform> TweenTransform(this MonoBehaviour owner)
        {
            return TweenTransform(owner, owner.transform);
        }

        public static Tween<RawTransform> TweenLocalTransform(this MonoBehaviour owner, Transform target)
        {
            return new Tween<RawTransform>(owner).Use(t => t.Transfer(target, true)).From(new(target, true));
        }

        public static Tween<RawTransform> TweenLocalTransform(this MonoBehaviour owner)
        {
            return TweenLocalTransform(owner, owner.transform);
        }

        public static Tween<Vector2> TweenAnchoredPosition(this MonoBehaviour owner, RectTransform target)
        {
            return new Tween<Vector2>(owner).Use(p => target.anchoredPosition = p).From(target.anchoredPosition);
        }

        public static Tween<Vector2> TweenAnchoredPosition(this MonoBehaviour owner)
        {
            return TweenAnchoredPosition(owner, owner.GetComponent<RectTransform>());
        }

        public static Tween<float> TweenAnchoredPositionX(this MonoBehaviour owner, RectTransform target)
        {
            return new Tween<float>(owner).Use(x => target.SetAnchoredPosX(x)).From(target.anchoredPosition.x);
        }

        public static Tween<float> TweenAnchoredPositionX(this MonoBehaviour owner)
        {
            return TweenAnchoredPositionX(owner, owner.GetComponent<RectTransform>());
        }

        public static Tween<float> TweenAnchoredPositionY(this MonoBehaviour owner, RectTransform target)
        {
            return new Tween<float>(owner).Use(y => target.SetAnchoredPosY(y)).From(target.anchoredPosition.y);
        }

        public static Tween<float> TweenAnchoredPositionY(this MonoBehaviour owner)
        {
            return TweenAnchoredPositionY(owner, owner.GetComponent<RectTransform>());
        }

        public static Tween<Vector3> TweenPosition(this MonoBehaviour owner, Transform target)
        {
            return new Tween<Vector3>(owner).Use(p => target.position = p).From(target.position);
        }

        public static Tween<Vector3> TweenPosition(this MonoBehaviour owner)
        {
            return TweenPosition(owner, owner.transform);
        }

        public static Tween<float> TweenPositionX(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(x => target.SetPosX(x)).From(target.position.x);
        }

        public static Tween<float> TweenPositionX(this MonoBehaviour owner)
        {
            return TweenPositionX(owner, owner.transform);
        }

        public static Tween<float> TweenPositionY(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(y => target.SetPosY(y)).From(target.position.y);
        }

        public static Tween<float> TweenPositionY(this MonoBehaviour owner)
        {
            return TweenPositionY(owner, owner.transform);
        }

        public static Tween<float> TweenPositionZ(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(z => target.SetPosZ(z)).From(target.position.z);
        }

        public static Tween<float> TweenPositionZ(this MonoBehaviour owner)
        {
            return TweenPositionZ(owner, owner.transform);
        }

        public static Tween<Vector3> TweenLocalPosition(this MonoBehaviour owner, Transform target)
        {
            return new Tween<Vector3>(owner).Use(p => target.localPosition = p).From(target.localPosition);
        }

        public static Tween<Vector3> TweenLocalPosition(this MonoBehaviour owner)
        {
            return TweenLocalPosition(owner, owner.transform);
        }

        public static Tween<float> TweenLocalPositionX(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(x => target.SetLocalPosX(x)).From(target.localPosition.x);
        }

        public static Tween<float> TweenLocalPositionX(this MonoBehaviour owner)
        {
            return TweenLocalPositionX(owner, owner.transform);
        }

        public static Tween<float> TweenLocalPositionY(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(y => target.SetLocalPosY(y)).From(target.localPosition.y);
        }

        public static Tween<float> TweenLocalPositionY(this MonoBehaviour owner)
        {
            return TweenLocalPositionY(owner, owner.transform);
        }

        public static Tween<float> TweenLocalPositionZ(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(z => target.SetLocalPosZ(z)).From(target.localPosition.z);
        }

        public static Tween<float> TweenLocalPositionZ(this MonoBehaviour owner)
        {
            return TweenLocalPositionZ(owner, owner.transform);
        }

        public static Tween<Quaternion> TweenRotation(this MonoBehaviour owner, Transform target)
        {
            return new Tween<Quaternion>(owner).Use(r => target.rotation = r).From(target.rotation);
        }

        public static Tween<Quaternion> TweenRotation(this MonoBehaviour owner)
        {
            return TweenRotation(owner, owner.transform);
        }

        public static Tween<Quaternion> TweenLocalRotation(this MonoBehaviour owner, Transform target)
        {
            return new Tween<Quaternion>(owner).Use(r => target.localRotation = r).From(target.localRotation);
        }

        public static Tween<Quaternion> TweenLocalRotation(this MonoBehaviour owner)
        {
            return TweenLocalRotation(owner, owner.transform);
        }

        public static Tween<Vector3> TweenScale(this MonoBehaviour owner, Transform target)
        {
            return new Tween<Vector3>(owner).Use(p => target.localScale = p).From(target.localScale);
        }

        public static Tween<Vector3> TweenScale(this MonoBehaviour owner)
        {
            return TweenScale(owner, owner.transform);
        }

        public static Tween<float> TweenScaleX(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(x => target.SetScaleX(x)).From(target.localScale.x);
        }

        public static Tween<float> TweenScaleX(this MonoBehaviour owner)
        {
            return TweenScaleX(owner, owner.transform);
        }

        public static Tween<float> TweenScaleY(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(y => target.SetScaleY(y)).From(target.localScale.y);
        }

        public static Tween<float> TweenScaleY(this MonoBehaviour owner)
        {
            return TweenScaleY(owner, owner.transform);
        }

        public static Tween<float> TweenScaleZ(this MonoBehaviour owner, Transform target)
        {
            return new Tween<float>(owner).Use(z => target.SetScaleZ(z)).From(target.localScale.z);
        }

        public static Tween<float> TweenScaleZ(this MonoBehaviour owner)
        {
            return TweenScaleZ(owner, owner.transform);
        }

        public static Tween TweenAny(this MonoBehaviour owner)
        {
            return new Tween(owner);
        }

        public static Tween<T> TweenAny<T>(this MonoBehaviour owner)
        {
            return new Tween<T>(owner);
        }

        public static Tween TweenDelayedAction(this MonoBehaviour owner, Action action, float delay)
        {
            return new Tween(owner).Duration(0).Delay(delay).OnStart(action);
        }

        public static TweenRunner RunDelayed(this MonoBehaviour owner, Action action, float delay)
        {
            return new Tween(owner).Duration(0).Delay(delay).OnStart(action).RunNew();
        }
    }
}
