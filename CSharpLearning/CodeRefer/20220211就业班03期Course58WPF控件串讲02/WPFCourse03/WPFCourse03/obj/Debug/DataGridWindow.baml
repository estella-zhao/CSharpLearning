   M S B A M L   `   `   `  ����F  BWPFCourse03, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:WPFCourse03WPFCourse03  5   	        WPFCourse03.DataGridWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:WPFCourse03     5   	   -   5          � Title$  DataGridWindow��5   	   $	��450��6    $	��800��6-   .��5	      � .+�5
   
   &   System.Windows.Controls.DataGrid  -   5        $��dgList��5      $	��285��5
      $��	52,39,0,0q�6    $	��Top=�63   $	��638��6K      AutoGenerateColumns .     CanUserAddRows .     
IsReadOnly .  "   VerticalScrollBarVisibility$
 Auto=�5   d      GridLinesVisibility$
 None=�6�   $   HorizontalScrollBarVisibility$
 Auto=�6�    �� AlternationCount$ 2��6�      HeadersVisibility$ Column=�6�   
�������
���� ��$��1q�6  	   ColumnHeaderHeight$	 30Q�63  
   RowHeaderWidth$
 30Q�6K     	RowHeight$ 30Q�6_     SelectionUnit$
 Cell=�6n     SelectionMode$ Single=�6�  $��Center=�6�  $��Center=�6�     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 学号��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6K      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 61   �� *StuId+   ElementStyle 5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value$ Center=�6B   �� 5       � ��
 �  ��6;   �� 5       � ��$
 Bold"�6;   5      5        5      $ 姓名��6%   $ 80 6M    61   �� *	StuName+   EditingElementStyle 5      �� 5      " ��6    .�5      ��  � ��$ Stretch=�6B   �� 5       � ��$ Center=�6I   �� 5       � ��
 ��  �6;   5       5      �� 5      " ��6    .�5       ��  � ��$ Center=�6B   �� 5!       � ��
 � � �6;   5"      5$      4  .System.Windows.Controls.DataGridComboBoxColumn  5%      -   5        
colClasses��$ 班级��5%   =   $	 100 6r      DisplayMemberPath$ 	ClassName��6~      SelectedValuePath$ ClassId��6�      SelectedValueBinding 6I   �� *	ClassId+6�   4  .System.Windows.Controls.DataGridCheckBoxColumn  5&      $ 性别��6)   $ 50 6P    65   �� *IsMale+6P   4  .System.Windows.Controls.DataGridTemplateColumn  5'      $ 电话��6)   $	 150 65      CellTemplate 5(      �� 5)      .R�5*      �� ��6$   �� *Phone+5+         CellEditingTemplate 5-      �� 5.      .R�5/      �� ��6&   �� *Phone+50      52        53      $ 修改��6)   $	 150 65    54      �� 55      .R�56      �� $��btnEdit��6%   $��修改��65   
 � Tag 6C   �� *StuId+57      5:      5<      5>      5?      