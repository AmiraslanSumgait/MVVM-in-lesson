   M S B A M L   `   `   `  ����?  ;MVVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:MVVM.Views
MVVM.Views  5   	   1clr-namespace:MVVM.ViewModelsMVVM.ViewModels  60       MVVM.Views.MainView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:MVVM.Views     5   	   4
ViewModelsclr-namespace:MVVM.ViewModels     60     � Title$  MainView��5   	   $	��500��6   $	��800��6'    � DataContext 5	      #  MVVM.ViewModels.MainViewModel  5
   
   6%   .��5      �� $	��350��6   .+�5   
   ��  �� DisplayMemberPath$ Model��6   $��28(�6J   ��6-   �� *Cars+6Z   �� 5   
   $��32(�6   .��6   Vendor6&   �� 5   
   
����  �$��32(�6B   ��6   �� *
Car.Vendor+6R   �� 5   
   $��32(�6   .��6   Model6%   �� 5   
   $��32(�6/   
����  ���6   �� *	Car.Model+6Q   �� 5   
   $��32(�6   .��6   Year6$   �� 5   
   $��32(�6.   
����  ���6   �� *
Car.Year+6P   �� 5   
   $��32(�61   $��10q�6?   ��6   �� *ShowCommand+.��6K   Show6Q   �� 5   
   $��32(�61   $��10q�6?   ��6   �� *EditCommand+.��6K   Edit6Q   5      5      