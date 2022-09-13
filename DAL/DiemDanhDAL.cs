using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class DiemDanhDAL
    {

        /*
          ALTER proc [dbo].[SelectLuongDD]
    @ID nvarchar(50),@ViPham nvarchar(50),@MoTa nvarchar(50)
    as
    begin
	begin
	update dbNhanVien set TrangThaiDD = 1 , DemDD+=1 where ID=@ID
	end
	begin
	insert into dbLuongCa(MaNV,ViPham,MoTa)values(@ID,@ViPham,@MoTa)
	end
	begin
	insert into dbLuongNgay(ID,mota,SoCa,Luong,vipham,LuongNgay,ngay)
	select id,
	dbca.mota ,
	soca,
	dbNhanVien.Luong,
	dbLuongCa.ViPham,
	dbNhanVien.Luong*dbLuongCa.ViPham as tongluongca ,ngaylam
	from dbluongca
	inner join dbNhanVien on dbNhanVien.id=dbLuongCa.MaNV
	inner join dbCa on dbNhanVien.MaCa=dbca.MaCa 
	where ID=@ID and 
	day(NgayDD)=day(getdate()) and month(NgayDD)=month(getdate())and year(NgayDD)=year(getdate())
	end

    end
         */

        public int DiemDanhNhanVien_TinhLuongNGay(string ID,string VP,string MT)//Diem danh nv tinh luong ngay
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@ID",
                Value = ID
            });
            pr.Add(new CustomParameter()
            {
                Key = "@ViPham",
                Value = VP
            });
            pr.Add(new CustomParameter()
            {
                Key = "@MoTa",
                Value = MT
            });
            return new DataSQL().Execute("[SelectLuongDD]", pr);
        }
        //reset moi ngay
        /*
         ALTER proc [dbo].[UpdateDD]
        @Key nvarchar(50)
        as
        begin
	        begin
	            update dbNhanVien set TrangThaiDD = 0
	            where NgayDD!=GETDATE()
	        end
	        update dbNhanVien set NgayDD =getdate()
	        update dbNhanVien set DemDD=0 where month(NgayDD)!=MONTH(getdate())
            end
         */
        public int ReseetDDD(string Key)
        {
            List<CustomParameter> pr = new List<CustomParameter>();
            pr.Add(new CustomParameter()
            {
                Key = "@Key",
                Value = Key
            });
            return new DataSQL().Execute("[UpdateDD]", pr);
        }
    }
}
