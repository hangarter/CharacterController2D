using NUnit.Framework;
using UnityEngine;

namespace test
{
    [TestFixture]
    public class CharacterController2DTest
    {
        private GameObject _gameObject;
        
        [SetUp]
        public void SetUp()
        {
            _gameObject = new GameObject();
        }
        
        [Test]
        public void Move_ReceivesVectorUp_MovesOneUnitUp()
        {
            // Given
            var characterController2D = _gameObject.AddComponent<CharacterController2D>();
            var moveDirection = Vector2.up;
            _gameObject.transform.position = new Vector3(2,3);
            
            // When
            characterController2D.Move(moveDirection);
            
            // Then
            Assert.AreEqual(new Vector3(2,4), _gameObject.transform.position);
        }
        
        [Test]
        public void Move_ReceivesVectorDown_MovesOneUnitDown()
        {
            // Given
            var characterController2D = _gameObject.AddComponent<CharacterController2D>();
            var moveDirection = Vector2.down;
            _gameObject.transform.position = new Vector3(2,3);
            
            // When
            characterController2D.Move(moveDirection);
            
            // Then
            Assert.AreEqual(new Vector3(2,2), _gameObject.transform.position);
        }
        
        [Test]
        public void Move_ReceivesVectorLeft_MovesOneUnitLeft()
        {
            // Given
            var characterController2D = _gameObject.AddComponent<CharacterController2D>();
            var moveDirection = Vector2.left;
            _gameObject.transform.position = new Vector3(2,3);
            
            // When
            characterController2D.Move(moveDirection);
            
            // Then
            Assert.AreEqual(new Vector3(1,3), _gameObject.transform.position);
        }
        
        [Test]
        public void Move_ReceivesVectorRight_MovesOneUnitRight()
        {
            // Given
            var characterController2D = _gameObject.AddComponent<CharacterController2D>();
            var moveDirection = Vector2.right;
            _gameObject.transform.position = new Vector3(2,3);
            
            // When
            characterController2D.Move(moveDirection);
            
            // Then
            Assert.AreEqual(new Vector3(3,3), _gameObject.transform.position);
        }
    }
}
