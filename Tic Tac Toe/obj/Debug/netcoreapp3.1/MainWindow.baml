   M S B A M L   `   `   `  ����F  BTic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tic_Tac_ToeTic_Tac_Toe  5   	       Tic_Tac_Toe.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Tic_Tac_Toe     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Tic Tac Toe��5	   	   $	��500��6   $	��500��6*    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$	 0.5q�60   �� 5       � ��$ 50(�6)   5      5      .��5      � -   5         �Name$ 	container��5       � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5    
   �� -   5        	 ��Name$	 btn00��5       $��0��6    $��0��6-   6=   �� 5!   
   -   5        $	 btn01��5!      $��0��6    $��1��6-   6=   �� 5"   
   -   5        $	 btn02��5"      $��0��6    $��2��6-   6=   �� 5$   
   -   5        $	 btn10��5$      $��1��6    $��0��6-   6=   �� 5%   
   -   5        $	 btn11��5%      $��1��6    $��1��6-   6=   �� 5&   
   -   5        $	 btn12��5&      $��1��6    $��2��6-   6=   �� 5(   
   -   5        $	 btn20��5(      $��2��6    $��0��6-   6=   �� 5)   
   -	   5        $	 btn21��5)      $��2��6    $��1��6-   6=   �� 5*   
   -
   5        $	 btn22��5*      $��2��6    $��2��6-   6=   5+      5,      