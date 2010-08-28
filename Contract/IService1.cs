﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Contract {
    public interface IService1 {
        // TODO: Implement the collection resource that will contain the SampleItem instances

        IList<SampleItem> GetCollection();

        SampleItem Create(SampleItem instance);

        SampleItem Get(int id);

        SampleItem Update(int id, SampleItem instance);

        void Delete(int id);
    }
}
