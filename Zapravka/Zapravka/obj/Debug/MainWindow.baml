   M S B A M L   `   `   `  ????C  ?Zapravka, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ZapravkaZapravka  5   	       Zapravka.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Zapravka     5   	     ? Title$  Главное окно??5   	   $	??450??6   $	??700??6+    ? Icon$ Resources/icon.jpg??67    ? WindowStartupLocation$ CenterScreen=?6Q   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??75 ?6   6*   ?? 5      6   ?? 5      $??75 ?6   6*   .+?5   
   ?? 
???   ?$??4q?6%   
??? ???6S   ?? 5   
   $??2??6   
???   ?$??4q?62   
??? ???6`   ?? 5   
   -   5        $??StackPanelMain??5       ?? Orientation$ Vertical=?6+   $??1??6B   
???????.+?5      ?? $ Vertical=?6   .+?5      ?? $??Center=?6   $??1??69   $,??&Выберите вид топлива??6F   $??26(?6b   $??comic sans ms)?6p   $??Center=?6?   $??5q?6?   5      5      ? 5      .+?5      ? $
??Left=?6   $??	150,0,0,0q?62   .+?5      ?? 
??? ???
???  ??$??3q?6C    ?? CornerRadius$ 90??6W   $	??165??6i   $	??165??6u   6?   ?? 5      
??????
??????$??3q?6S   $ 90??6g   $	??150??6y   $	??150??6?   6?   ?? 5      -   5        $	??125??5   .   $	??125??6:   
????? ?$??comic sans ms)?6`   $??40(?6{   
???????$??92??6?    ? 	Resources 5       ?? 
TargetType ?? Property	 ?? Value??%d   '??       ?? 5      " ??6$   .?5   "   ??  ?@??CornerRadius$	 90??6A   6N   5      5      5       5!      ? 5"      $??Right=?6   $??	0,0,150,0q?63   .+?5#      ?? 
??? ???
???  ??$??3q?6C   $ 90??6W   $	??165??6i   $	??165??6u   6?   ?? 5$      
??????
??????$??3q?6S   $ 90??6g   $	??150??6y   $	??150??6?   6?   ?? 5%      -   5        $	??125??5%   .   $	??125??6:   
???  ??$??comic sans ms)?6X   $??40(?6s   
???????$??95??6?    5&      ??%d   '??       ?? 5'      " ??6$   .?5(   "   ??  ?@??CornerRadius$	 90??6A   6N   5)      5*      5+      5,      5.      5/      ?? 50   
   $??Center=?6   $??1??61   $??45.45 руб/лтр??6>   $??22(?6S   $
??Bold"?6a   $??times new roman)?6s   $??Center=?6?   $??5,195,240,5q?6?   51      ?? 52   
   $??Center=?6   $??1??61   $??48.55 руб/лтр??6>   $??22(?6S   $
??Bold"?6a   $??times new roman)?6s   $??Center=?6?   $??240,195,5,5q?6?   53      ?? 54   
   $??1??6   $	??285??6   $??0,0,0,0q?6+   
???   ?$??4q?6P   6f   ?? 55   
   $P??JДобро пожаловать на заправочную станцию??6   $??26(?6C   $??comic sans ms)?6Q   $??Center=?6l   $??Center=?6?   $??40,5,5,5q?6?   6?   ?? 57   
   $??60??6   $??Resources/Logo.jpg??6   $
??Left=?68   $??15,0,0,0q?6S   6g   ?? 58   
   -   5        $
??Left=?58      $??2??6-   $	??200??6:   $??60??6F   
??? E??$??
Выйти??6i   $??26(?6y   $??Comic sans ms)?6?   $??15,0,0,0q?6?    59      ??%d   '??       ?? 5:      " ??6   .?5;      ??  ?@??CornerRadius$	 35??65   6B   5<      5=      5>      ?? 5?   
   $??2??6   $??Выбрано: ??6!   $??26(?62   $??comic sans ms)?6@   $??Center=?6[   $??Center=?6x   $??5q?6?   6?   ?? 5@   
   -   5        $??ChooseTextBlock??5@      
???????$??2??6>   $??26(?6K   $??comic sans ms)?6Y   $??Center=?6t   $??Center=?6?   $??	165,5,5,5q?6?   6?   ?? 5A   
   -   5        $??Right=?5A      $??2??6.   $	??200??6;   $??60??6G   
??? ? ?$??Продолжить??6f   $??26(?6{   $??Comic sans ms)?6?   $??0,0,15,0q?6?    5B      ??%d   '??       ?? 5C      " ??6   .?5D      ??  ?@??CornerRadius$	 35??65   6B   5E      5F      5G      5H      5I      