PGDMP         ;                x         
   apimanager    12.3    12.3                0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                      false                       0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                      false                       0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                      false                       1262    16393 
   apimanager    DATABASE     �   CREATE DATABASE apimanager WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Portuguese_Brazil.1252' LC_CTYPE = 'Portuguese_Brazil.1252';
    DROP DATABASE apimanager;
                postgres    false            �            1259    16396    leftdiff    TABLE     I   CREATE TABLE public.leftdiff (
    id integer NOT NULL,
    json text
);
    DROP TABLE public.leftdiff;
       public         heap    postgres    false            �            1259    16394    leftdiff_id_seq    SEQUENCE     �   CREATE SEQUENCE public.leftdiff_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 &   DROP SEQUENCE public.leftdiff_id_seq;
       public          postgres    false    203                       0    0    leftdiff_id_seq    SEQUENCE OWNED BY     C   ALTER SEQUENCE public.leftdiff_id_seq OWNED BY public.leftdiff.id;
          public          postgres    false    202            �            1259    16407 	   rightdiff    TABLE     ^   CREATE TABLE public.rightdiff (
    id integer NOT NULL,
    json text,
    idleft integer
);
    DROP TABLE public.rightdiff;
       public         heap    postgres    false            �            1259    16405    rightdiff_id_seq    SEQUENCE     �   CREATE SEQUENCE public.rightdiff_id_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 '   DROP SEQUENCE public.rightdiff_id_seq;
       public          postgres    false    205                       0    0    rightdiff_id_seq    SEQUENCE OWNED BY     E   ALTER SEQUENCE public.rightdiff_id_seq OWNED BY public.rightdiff.id;
          public          postgres    false    204            �
           2604    16399    leftdiff id    DEFAULT     j   ALTER TABLE ONLY public.leftdiff ALTER COLUMN id SET DEFAULT nextval('public.leftdiff_id_seq'::regclass);
 :   ALTER TABLE public.leftdiff ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    202    203    203            �
           2604    16410    rightdiff id    DEFAULT     l   ALTER TABLE ONLY public.rightdiff ALTER COLUMN id SET DEFAULT nextval('public.rightdiff_id_seq'::regclass);
 ;   ALTER TABLE public.rightdiff ALTER COLUMN id DROP DEFAULT;
       public          postgres    false    204    205    205                      0    16396    leftdiff 
   TABLE DATA                 public          postgres    false    203   .                 0    16407 	   rightdiff 
   TABLE DATA                 public          postgres    false    205                     0    0    leftdiff_id_seq    SEQUENCE SET     >   SELECT pg_catalog.setval('public.leftdiff_id_seq', 17, true);
          public          postgres    false    202                       0    0    rightdiff_id_seq    SEQUENCE SET     ?   SELECT pg_catalog.setval('public.rightdiff_id_seq', 10, true);
          public          postgres    false    204            �
           2606    16404    leftdiff leftdiff_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.leftdiff
    ADD CONSTRAINT leftdiff_pkey PRIMARY KEY (id);
 @   ALTER TABLE ONLY public.leftdiff DROP CONSTRAINT leftdiff_pkey;
       public            postgres    false    203            �
           2606    16415    rightdiff rightdiff_pkey 
   CONSTRAINT     V   ALTER TABLE ONLY public.rightdiff
    ADD CONSTRAINT rightdiff_pkey PRIMARY KEY (id);
 B   ALTER TABLE ONLY public.rightdiff DROP CONSTRAINT rightdiff_pkey;
       public            postgres    false    205               �  x���o�0���WX�C[�U�4m�EL��F6M��p�a16��֬��>�f��X��!~ؾ�~�̝?��K?,I�d�̯9n+7rY2�|�R\��Q�i����#��.���?S�z��rd�I#lX�=�7V>R���xl�R�w��U?z\jjO�gjJÑ����9�W�Gn8+���דRgh'sa:Z<s>��ĺ�R�H���U���
T����=�]S�D�@�V�J�}ubDY��&D���L&w�0�Nn_sōK��%"x[uT�B�H�m,#I�����&��d&��R�1�Z�pE�d����p�ژ��գ<��<�˿���L�B	�#�r� ��nٕ%��A�P4��B-:�\*� ����q�w�����6�̾viԪ����%CWlUdv���x��`��->Y�7���b�{%9l�t��G��ܜ3>�@��}��Ϡ{?+�X3         �  x���MO�0���#���()[����Z��
H� $ԃ;�G���B��]JG�H��7�;���$���7�[h�TVٹ����*�����P���=��hy�H�tH��p���P����$���83A����#3ed��q�/O��O�i��V$�UeC(an��dL�Y�I�\ �ͥ�ɔTڐ���-[-�"�ʊB���N`�nZ��U�0�
�1�Jt���?G#���5%�xA�� �v���=
�ӓ��G'��GR㺎�����G�V�R�G��+��W�?˒}|Y�~�h�ϝ��z��Di���+WB�.dYÙ��ap��s�5E禓�(Ӫ�ԇ��4�K!qr��x:��ˏ*E��[�]�"��e?�U�S)tFp�
2-p�Kހ������(�|��'BD�(�J�+����!��;�&^n8�10����     