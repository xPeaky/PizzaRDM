package
{
   import flash.display.Sprite;
   import flash.utils.ByteArray;
   import flash.utils.Endian;
   
   public class §_a_-_---§ extends Sprite
   {
      
      private static var §_a_--_-§:Class = §_a_-_-__§;
      
      private static var §_a_--_§:Class = §_a_-_§;
      
      private static var §_a_-__§:Class = §_a_---§;
      
      private static var §_a_-____§:Array = new Array();
      
      private static var §_a_----§:Array = new Array();
      
      private static var §_a_-___-§:Boolean = false;
      
      private static var §_a_--§:int;
       
      
      public function §_a_-_---§()
      {
         super();
      }
      
      private static function §_a_-_--§() : void
      {
         var _loc1_:ByteArray = new §_a_--_-§() as ByteArray;
         var _loc2_:ByteArray = new §_a_--_§() as ByteArray;
         var _loc3_:ByteArray = new §_a_-__§() as ByteArray;
         _loc3_.endian = Endian.LITTLE_ENDIAN;
         §_a_--§ = _loc3_.readInt();
         var _loc4_:int = _loc2_.readByte();
         var _loc5_:int = 0;
         while(_loc5_ < _loc4_)
         {
            §_a_-__-_§(_loc2_);
            _loc5_++;
         }
         _loc4_ = _loc1_.readInt();
         var _loc6_:int = 0;
         while(_loc6_ < _loc4_)
         {
            §_a_--__§(_loc1_,§_a_----§[_loc6_ % §_a_----§.length]);
            _loc6_++;
         }
         §_a_-___-§ = true;
      }
      
      private static function §_a_--__§(param1:ByteArray, param2:ByteArray) : void
      {
         var _loc3_:int = param1.readInt();
         var _loc4_:ByteArray = new ByteArray();
         param1.readBytes(_loc4_,0,_loc3_);
         var _loc5_:§_a_-_-_§ = new §_a_-_-_§(param2);
         _loc5_.§_a_---_§(_loc4_);
         _loc4_.position = 0;
         §_a_-____§.push(_loc4_.readUTFBytes(_loc4_.length));
      }
      
      private static function §_a_-__-_§(param1:ByteArray) : void
      {
         var _loc2_:ByteArray = new ByteArray();
         param1.readBytes(_loc2_,0,16);
         _loc2_.position = 0;
         §_a_----§.push(_loc2_);
      }
      
      public static function §_a_--_--§(param1:int) : String
      {
         if(!§_a_-___-§)
         {
            §_a_-_--§();
         }
         return §_a_-____§[param1 ^ §_a_--§];
      }
   }
}
