   M S B A M L   `   `   `  ����Q  MN_th_Tribonacci_Number, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:N_th_Tribonacci_NumberN_th_Tribonacci_Number  5   	   '    !N_th_Tribonacci_Number.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:N_th_Tribonacci_Number     5   	   $��Times New Roman)�5   	   $��25(�5	   	   ���	#FF333333  � Title$  N-th Tribonacci Number��5   	   $	��450��5   	   $	��600��5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��35 �6   .+�5   
   � $��0��6   .+�5      �� -   5         ��Name$ label��5      $��Input：��5      
�������$��25(�5      $
��Left=�5      $��
192,92,0,0q�5      $	��Top=�5      �� 5      -   5        $ labe4��5      $��Fibonacci Sequence：��5      
�������$��25(�5!      $
��Left=�5"      $��
45,157,0,0q�5#      $	��Top=�5$      �� 5&      -   5         ��Name$ checkBox_DPSelect��5&      $��DP��5'      $��13(�5(      
������� d� 	IsChecked$ FalseY�5*      $
��Left=�5+      $��
437,99,0,0q�5,      $	��Top=�5-       � LayoutTransform 5/      �� 50       �� ScaleX$ 2Q�6%    �� ScaleY$ 2Q�60   53      �� 55      -   5        	 ��Name$	 textBox��55      $��10��56      $��25(�57      $
��Left=�58      $��
281,95,0,0q�59      
 �� TextWrapping$

 Wrap=�5:      $	��Top=�5;      $	��148��5<      $��35��5=      �� 5>      -   5        $	 textBox_answer��5>      $��25(�5?      $
��Left=�5@      $��280,159,0,0q�5A      $

 Wrap=�5B      $	��Top=�5C       �� 
IsReadOnly . $	��180��5E      $��35��5F      �� 5H      -   5         ��Name$ button��5H      $��	Calculate��5I      $
��Left=�5J      $��205,255,0,0q�5K      $	��Top=�5L      $	��200��5M      $��80��6   5N      5O      � 5Q   
   ���#000000$��1��6$   .+�5R      ]� 
������ $��Stretch=�61   $
��10,5q�6O   .+�5S      �� $��
Message：��6   $��20(�6,   ���#FFFFFF$��Center=�6O   $
��Left=�6j   �� 5T      $��Center=�6   $��Stretch=�67   ��5U      �� *NotifiedMessage+��6=   �� *NotifiedColor+5V      5W      5X      5Y      