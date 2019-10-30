using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace ScriptureJournal.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ScriptureJournalContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ScriptureJournalContext>>()))
            {
                // Look for any Scriptures.
                if (context.Scriptures.Any())
                {
                    return;   // DB has been seeded
                }

                context.Scriptures.AddRange(
                    new Scripture
                    {
                        Book = BookName.Alma,
                        Chapter = 36,
                        Verse = 27,
                        Notes = "Trials"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
