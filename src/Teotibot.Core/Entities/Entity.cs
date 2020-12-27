﻿namespace Teotibot.Core.Entities
{
    public abstract class Entity<TId>
    {        
        public TId Id { get; }

        protected Entity(TId id)
        {
            Id = id;
        }
    }
}
