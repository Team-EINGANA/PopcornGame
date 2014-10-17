﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Popcorn.Interfaces;

namespace Popcorn
{
    public interface IDrawable
    {
        void AddObject(IGameObject drawableObject);
        void RemoveObject(IGameObject drawableObject);
        void RedrowObject(IGameObject drawableObject);
    }
}
