   M S B A M L   `   `   `  ����F  BWPFCourse02, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFCourse02WPFCourse02  5   	       WPFCourse02.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFCourse02     5   	     � Title$  基本控件使用��5   	   $	��450��6   $	��800��6%   .��5	      �� 
��� ���$��2q�6"    �� CornerRadius$ 	2,2,16,16��66   $��10q�6O   ._�5
   
   � .+�5      �� $
��Left=�6   $��	49,32,0,0q�60   $	��Top=�6C   $��27��6[   $	��106��6g   ��5      �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� $��	用户名��6$   $��0,0,10,0q�6/   �� 5      $��	用户名��6$   5      5      �� 5      -   5        $��Button��5      $
��Left=�6&   $��
34,290,0,0q�6A   $	��Top=�6U   $��75��6m    J� RenderTransformOrigin$ 
0.503,2.11&�6x   6�   G� 5      $
��Left=�6   $��
160,32,0,0q�65   $	��Top=�6I   $	��168��6a   $��27��6m    G� Password$ 123456��6y    G� PasswordChar$ *��6�   �� 5      $
��Left=�6   $��23��61   $��
380,32,0,0q�6=    �� TextWrapping$
 Wrap=�6Q   $��TextBox��6e   $	��Top=�6t   $	��145��6�   �� 5      $��CheckBox��6   $
��Left=�6*   $��	94,99,0,0q�6E   $	��Top=�6X   $��21��6p   $��77��6|   $ 1.804,0.646&�6�   �� 5      $��CheckBox��6   $
��Left=�6*   $��
200,99,0,0q�6E   $	��Top=�6Y   �� 5      $��CheckBox��6   $
��Left=�6*   $��
305,99,0,0q�6E   $	��Top=�6Y   	� 5      $��学生��6    	� 	GroupName$ g��6'    d� 	IsChecked$
 TrueY�65   $
��Left=�6G   $��
92,128,0,0q�6b   $	��Top=�6v   	� 5      $��老师��6   $ g��6'   $
��Left=�65   $��210,128,0,0q�6P   $	��Top=�6e   	� 5      $��管理��6   $ a��6'   $
��Left=�65   $��344,125,0,0q�6P   $	��Top=�6e   �� 5      -   5        $	��img��5      $
��Left=�6   $��81��6:   $��
594,32,0,0q�6F   $	��Top=�6Z   $	��116��6r   $
��Fill=�6   �� 5      -   5        $
��sd01��5      $
��Left=�6!   $��
94,159,0,0q�6<   $	��Top=�6P   $��33��6h   	 � Minimum$	 1Q�6s   
 � Maximum$	
 100Q�6    � Value$ 45Q�6�    �� TickPlacement$ TopLeft=�6�    �� IsSelectionRangeEnabled .  �� SelectionStart$ 10Q�6�    �� SelectionEnd$ 60Q�6�    �� Orientation$ Vertical=�6�    �� TickFrequency$ 5Q�6  $��93��6   �� IsDirectionReversed . 6*  �� 5      $
��Left=�6   $��305,175,0,0q�63   $
��Wrap=�6H   $��	TextBlock��6\   $	��Top=�6�   $ 0.812,0.645&�6�   $��18��6�   $��62��6�   ��6m   ��  �� ElementName$
 sd01�� �� Path$ Value�6�   � 5       -   5        $
��pbar��5       $
��Left=�6&   $��16��6A   $��152,220,0,0q�6M   $	��Top=�6b   $	��180��6z   $ 0Q�6�   $	 0Q�6�   $	
 100Q�6�   5"      5$      5&      