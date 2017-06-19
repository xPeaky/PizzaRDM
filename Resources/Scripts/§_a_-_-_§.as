package
{
   import flash.utils.ByteArray;
   
   public class §_a_-_-_§
   {
       
      
      private var §_a_-___§:int = 0;
      
      private var §_a_---__§:int = 0;
      
      private var §_a_-_-_-§:ByteArray;
      
      private const §_a_-__--§:uint = 256;
      
      public function §_a_-_-_§(param1:ByteArray = null)
      {
         super();
         this.§_a_-_-_-§ = new ByteArray();
         if(param1)
         {
            this.§_a_-§(param1);
         }
      }
      
      public function §_a_--___§() : uint
      {
         return this.§_a_-__--§;
      }
      
      public function §_a_-§(param1:ByteArray) : void
      {
         var _loc2_:int = 0;
         var _loc3_:* = 0;
         var _loc4_:int = 0;
         _loc2_ = 0;
         while(_loc2_ < 256)
         {
            this.§_a_-_-_-§[_loc2_] = _loc2_;
            _loc2_++;
         }
         _loc3_ = 0;
         _loc2_ = 0;
         while(_loc2_ < 256)
         {
            _loc3_ = _loc3_ + this.§_a_-_-_-§[_loc2_] + param1[_loc2_ % param1.length] & 255;
            _loc4_ = this.§_a_-_-_-§[_loc2_];
            this.§_a_-_-_-§[_loc2_] = this.§_a_-_-_-§[_loc3_];
            this.§_a_-_-_-§[_loc3_] = _loc4_;
            _loc2_++;
         }
         this.§_a_-___§ = 0;
         this.§_a_---__§ = 0;
      }
      
      private function §_a_-__-§() : uint
      {
         var _loc1_:int = 0;
         this.§_a_-___§ = this.§_a_-___§ + 1 & 255;
         this.§_a_---__§ = this.§_a_---__§ + this.§_a_-_-_-§[this.§_a_-___§] & 255;
         _loc1_ = this.§_a_-_-_-§[this.§_a_-___§];
         this.§_a_-_-_-§[this.§_a_-___§] = this.§_a_-_-_-§[this.§_a_---__§];
         this.§_a_-_-_-§[this.§_a_---__§] = _loc1_;
         return this.§_a_-_-_-§[_loc1_ + this.§_a_-_-_-§[this.§_a_-___§] & 255];
      }
      
      public function §_a_--_-_§() : uint
      {
         return 1;
      }
      
      public function §_a_-_--_§(param1:ByteArray) : void
      {
         var _loc2_:uint = 0;
         while(_loc2_ < param1.length)
         {
            param1[_loc2_++] = param1[_loc2_++] ^ this.§_a_-__-§();
         }
      }
      
      public function §_a_---_§(param1:ByteArray) : void
      {
         this.§_a_-_--_§(param1);
      }
      
      public function §_a_-_-§() : void
      {
         var _loc1_:uint = 0;
         if(this.§_a_-_-_-§ != null)
         {
            _loc1_ = 0;
            while(_loc1_ < this.§_a_-_-_-§.length)
            {
               this.§_a_-_-_-§[_loc1_] = Math.random() * 256;
               _loc1_++;
            }
            this.§_a_-_-_-§.length = 0;
            this.§_a_-_-_-§ = null;
         }
         this.§_a_-___§ = 0;
         this.§_a_---__§ = 0;
      }
   }
}
