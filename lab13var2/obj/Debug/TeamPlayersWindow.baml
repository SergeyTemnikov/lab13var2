   M S B A M L   `   `   `  ����D  @lab13var2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:lab13var2	lab13var2  5   	   !    lab13var2.TeamPlayersWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:lab13var2     5   	     � Title$  TeamPlayersWindow��5   	   $	��450��6#   $	��400��60   .��5	      �  � RowDefinitions 5
   
   �� 5      �� 5      $��10 �6   �� 5      �� 5      $��10 �6   �� 5      $��6* �6   .+�5   
   �� 
������$��0��6&   $��0��66   $��4��6C   6Y   �� 5   
   -   5        $��txtName��5      $��0��6#   $��0��63   $��4��6@   $
��Wrap=�6T   $��Команда: ��6h   
���   �$
��Bold"�5       �� TextAlignment$ Center=�6'   $��Center=�6>   �� 5   
   -   5        $��txtPlayersCount��5      $��0��6+   $��2��6;   $��4��6H   $
��Wrap=�6\   $+��%Количество игроков: ��6p   
���   �$
 Left=�5      $��Center=�6+   $��	15,5,15,5q�6F   &   System.Windows.Controls.DataGrid  5   
   -   5        $��	dgPlayers��5      $��4��6$      
IsReadOnly .    AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Имя��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6K   1  +System.Windows.Controls.DataGridBoundColumn   Binding 62   �� *Name+6K   5      5      5      