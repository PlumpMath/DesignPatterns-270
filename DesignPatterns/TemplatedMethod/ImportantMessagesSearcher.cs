﻿using System;

namespace TemplatedMethod
{
    internal class ImportantMessagesSearcher : MessagesSearcher
    {
        public ImportantMessagesSearcher(DateTime dateSent, String personName)
            : base(dateSent, personName, 3) // «3» означає, що повідомлення важливе
        {
        }

        // Одна операція перевантажена (IMPORTANT в кінці)
        protected override void CreateImportanceCriteria()
        {
            Console.WriteLine("Special importance criteria has been formed: IMPORTANT");
        }
    }
}
