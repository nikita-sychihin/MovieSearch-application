using System.Collections.Generic;
using System.Data.Entity;

namespace MovieSearchАpplication.Models
{
    public class MainDbInitializer : DropCreateDatabaseAlways<AppContext>
    {
        protected override void Seed(AppContext bd)
        {
            Actors a1 = new Actors {Id = 1, Name = "Трэвис Фиммел" };
            Actors a2 = new Actors {Id = 2, Name = "Бен Фосте"};
            Actors a3 = new Actors { Id = 3, Name = "Паула Пэттон" };
            Actors a4 = new Actors { Id = 4, Name = "Чарли Ханнэм" };
            Actors a5 = new Actors { Id = 5, Name = " Джуд Лоу," };
            Actors a6 = new Actors { Id = 6, Name = "Аннабелль Уоллис," };
            Actors a7 = new Actors { Id = 7, Name = "Том Хэнкс" };
            Actors a8 = new Actors { Id = 7, Name = "Одри Тоту" };
            Actors a9 = new Actors { Id = 7, Name = "Иэн МакКеллен" };
            Actors a10 = new Actors { Id = 7, Name = "Дермот Малруни" };
            Actors a11 = new Actors { Id = 7, Name = "Аманда Крю" };
            Actors a12 = new Actors { Id = 7, Name = "Джеймс Вудс" };
            Actors a13 = new Actors { Id = 7, Name = "Кейт Бекинсейл" };
            Actors a14 = new Actors { Id = 7, Name = "Джим Стёрджесс" };
            Actors a15 = new Actors { Id = 7, Name = "Брендан Глисон" };

            bd.Actor.Add(a1);
            bd.Actor.Add(a2);
            bd.Actor.Add(a3);
            bd.Actor.Add(a4);
            bd.Actor.Add(a5);
            bd.Actor.Add(a6);
            bd.Actor.Add(a7);
            bd.Actor.Add(a8);
            bd.Actor.Add(a9);
            bd.Actor.Add(a10);
            bd.Actor.Add(a11);
            bd.Actor.Add(a12);
            bd.Actor.Add(a13);
            bd.Actor.Add(a14);
            bd.Actor.Add(a15);



            Films f1 = new Films { Id = 1, Name = "Варкрафт", Image = "https://upload.wikimedia.org/wikipedia/ru/thumb/2/21/Warcraft_poster.jpg/203px-Warcraft_poster.jpg",
            Genre = "Приключения , Боевики , Фэнтези , Зарубежные", Released = "2016", Director = "Дункан Джонс", Actors = new List<Actors>() { a1,a2,a3 } };
            Films f2 = new Films { Id = 2, Name = "Меч короля Артура", Image = "https://www.megacritic.ru/media/reviews/photos/original/9c/2d/ec/824437-35-1491831681.jpg",
            Genre = "Драмы , Приключения , Боевики , Фэнтези ", Released = "2016", Director = "Гай Ричи", Actors = new List<Actors>() { a4,a5,a6 } };
            Films f3 = new Films { Id = 3, Name = "Код Да Винчи", Image = "https://lentachel.ru/netcat_files/Image/foto/2018/03/16/5617c796d7c9c1fe9ef230ca1f33dffc/Kod_da_Vinchi.jpg",
            Genre = "Триллеры , Детективы , Зарубежные ", Released = "2006", Director = "Рон Ховард", Actors = new List<Actors>() { a7,a8,a9 } };
            Films f4 = new Films { Id = 4, Name = "Джобс: Империя соблазна", Image = "https://st.kp.yandex.net/images/film_iphone/iphone360_677798.jpg",
            Genre = "Драмы , Зарубежные , Биография ", Released = "2013", Director = "Джошуа Майкл Штерн", Actors = new List<Actors>() { a10,a11,a12 } };
            Films f5 = new Films { Id = 5, Name = "Обитель проклятых", Image = "https://st.kp.yandex.net/images/film_iphone/iphone360_572035.jpg",
            Genre = "Триллеры , Зарубежные  ", Released = "2014", Director = "Брэд Андерсон", Actors = new List<Actors>() { a13,a14,a15 } };

            bd.Film.Add(f1);
            bd.Film.Add(f2);
            bd.Film.Add(f3);
            bd.Film.Add(f4);
            bd.Film.Add(f5);

            base.Seed(bd);
        }
    }
}