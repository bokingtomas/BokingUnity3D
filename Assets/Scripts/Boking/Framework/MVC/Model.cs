using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Boking
{
    public class Model : IEventProtocol
    {
        private readonly EventProtocol m_Event = new EventProtocol();

        public void AddEvent(int key, EventListener listener)
        {
            m_Event.AddEvent(key, listener);
        }

        public void RemoveEvent(int key)
        {
            m_Event.RemoveEvent(key);
        }

        public void RemoveEvent(int key, EventListener listener)
        {
            m_Event.RemoveEvent(key, listener);
        }

        public void DispatchEvent(int key, params object[] args)
        {
            m_Event.DispatchEvent(key, args);
        }
    }

}
