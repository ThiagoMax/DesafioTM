﻿using DesafioTM.Model.DTO;
using System;
using System.Collections.Generic;

namespace DesafioTM.Business
{
    public interface IEvent
    {
        EventDTO Create(EventDTO evento);
        EventDTO FindById(long id);
        List<EventDTO> FindByName(string type);
        List<EventDTO> FindByType(string type);
        List<EventDTO> FindByLocation(string location);
        List<EventDTO> FindByOrganizerName(string name);
        List<EventDTO> FindByEventDate(string date);
        EventDTO Update(EventDTO evento);
        void Delete(long id);
        List<EventDTO> FindAll();

    }
}
