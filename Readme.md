public static void Main (string[] args)
        {
            Repository rep = new Repository();

            Student eudes = new Student(201802538);
            eudes.setName("Eudes");

            if (rep.exist(eudes.getMatriculation()))
            {
                Console.WriteLine("Exist");
            } else
            {
                rep.insert(eudes);
            }

            Student jamilly = new Student(201802535);
            jamilly.setName("Jamilly");

            if (rep.exist(jamilly.getMatriculation()))
            {
                Console.WriteLine("Exist");
            }
            else
            {
                rep.insert(jamilly);
            }

            Student gabriel = new Student(201802530);
            gabriel.setName("Gabriel");

            if (rep.exist(gabriel.getMatriculation()))
            {
                Console.WriteLine("Exist");
            }
            else
            {
                rep.insert(gabriel);
            }

            Console.WriteLine(rep.show());

            /*if (rep.exist(201802538))
            {
                rep.remove(rep.search(eudes.getMatriculation()));
            } else
            {
                Console.WriteLine("Student don't exist!");
            }

            Console.WriteLine(rep.show());
            */

            jamilly.setName("Jamilly Vic");
            jamilly.setNote2(10);

            rep.update(jamilly);

            Console.WriteLine(rep.show()+" | "+rep.getIndex(jamilly));


        }