﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HeroPecApp
{
    public static class Animator
    {
        public static List<Animation> AnimationList = new List<Animation>();

        public static int Count()
        {
            return AnimationList.Count;
        }

        private static Thread AnimatorThread;

        private static double Interval;

        public static bool IsWork = false;

        public static void Start()
        {
            IsWork = true;
            Interval = 1; // FPS ~66

            AnimatorThread = new Thread(AnimationInvoker)
            {
                IsBackground = true,
                Name = "UI Animation"
            };

            AnimatorThread.Start();
        }

        private static void AnimationInvoker()
        {
            try
            {
                while (IsWork)
                {
                    AnimationList.RemoveAll(a => a == null || a.Status == Animation.AnimationStatus.Completed);

                    Parallel.For(0, Count(), index =>
                    {
                        if (index < AnimationList.Count)
                        {
                            try
                            {
                                AnimationList[index].UpdateFrame();
                            }
                            catch (System.NullReferenceException)
                            { }
                        }
                    });

                    Thread.Sleep((int)Interval);
                }
            }
            catch (System.Exception)
            {

            }
        }

        public static void Request(Animation Anim, bool ReplaceIfExists = true)
        {
            Debug.WriteLine("Запуск анимации: " + Anim.ID + "| TargetValue: " + Anim.TargetValue);
            Anim.Status = Animation.AnimationStatus.Requested;

            Animation dupAnim = GetDuplicate(Anim);

            if (dupAnim != null)
            {
                if (ReplaceIfExists == true)
                {
                    dupAnim.Status = Animation.AnimationStatus.Completed;
                }
                else
                {
                    return;
                }
            }

            AnimationList.Add(Anim);
        }

        private static Animation GetDuplicate(Animation Anim)
        {
            return AnimationList.Find(a => a.ID == Anim.ID);
        }
    }
}