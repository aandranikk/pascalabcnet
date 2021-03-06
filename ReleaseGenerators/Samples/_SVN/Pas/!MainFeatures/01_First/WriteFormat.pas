/// Использование процедуры WritelnFormat
begin
  // Вывод в обратном порядке
  WritelnFormat('{2},{1},{0}',1,2,3);
  // Вывод фигурных скобочек
  WritelnFormat('{{}}{0}','Вывод фигурных скобочек в форматной строке');
  // Задание ширины поля вывода
  WritelnFormat('{0,10:f}',3.1415);
  // Задание количества знаков после запятой для вещественного числа
  WritelnFormat('{0:f3}',3.1415);
end.